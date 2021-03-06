﻿using System;
using System.Linq;
using FluentValidation;
using MyLibrary.Core.CrossCuttingConcerns.Validation.FluentValidation;
using PostSharp.Aspects;

namespace MyLibrary.Core.Aspects.PostSharp.ValidationAspects
{
    [Serializable]
    public class FluentValidationAspect : OnMethodBoundaryAspect
    {
        Type _validatorType;

        public FluentValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            if (_validatorType.BaseType != null)
            {
                var entityType = _validatorType.BaseType.GetGenericArguments()[0];
                var entities = args.Arguments.Where(t => t.GetType() == entityType);

                foreach (var entity in entities)
                {
                    ValidatorTool.Validate(validator, entity);
                }
            }
        }
    }
}
