using FluentValidation;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.Business.ValidationRules.FluentValidation
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(p => p.FullName).NotEmpty();
            RuleFor(p => p.FullName).MaximumLength(50);
        }
    }
}
