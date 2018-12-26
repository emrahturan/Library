using FluentValidation;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.Business.ValidationRules.FluentValidation
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(30);
        }
    }
}
