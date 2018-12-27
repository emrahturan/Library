using System;
using FluentValidation;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.Business.ValidationRules.FluentValidation
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(p => p.AuthorId).NotNull();
            RuleFor(p => p.CategoryId).NotNull();
            RuleFor(p => p.Isbn)
                .NotNull()
                .Matches(@"^\d{13}$");
            RuleFor(p => p.Name)
                .NotEmpty()
                .MaximumLength(50);
            RuleFor(p => p.PublishedYear)
                .NotNull()
                .GreaterThan((short)1900)
                .LessThan((short)(DateTime.Now.Year + 1));
            RuleFor(p => p.PublisherId).NotNull();
        }

    }
}


