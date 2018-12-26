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
            RuleFor(p => p.ISBN).NotEmpty();
            RuleFor(p => p.ISBN).Length(13);
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(50);
            RuleFor(p => p.PublishedYear).NotNull();
            RuleFor(p => p.PublishedYear).GreaterThan(1900).LessThan(DateTime.Now.Year + 1);
            RuleFor(p => p.PublisherId).NotNull();
        }
    }
}
