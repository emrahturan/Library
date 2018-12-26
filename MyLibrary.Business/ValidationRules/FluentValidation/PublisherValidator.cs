using FluentValidation;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.Business.ValidationRules.FluentValidation
{
    public class PublisherValidator : AbstractValidator<Publisher>
    {
        public PublisherValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .MaximumLength(50);
        }
    }
}
