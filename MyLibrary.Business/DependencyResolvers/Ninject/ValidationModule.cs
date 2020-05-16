using FluentValidation;
using MyLibrary.Business.ValidationRules.FluentValidation;
using MyLibrary.Entities.Concrete;
using Ninject.Modules;

namespace MyLibrary.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Author>>().To<AuthorValidator>().InSingletonScope();
            Bind<IValidator<Book>>().To<BookValidator>().InSingletonScope();
            Bind<IValidator<Category>>().To<CategoryValidator>().InSingletonScope();
            Bind<IValidator<Publisher>>().To<PublisherValidator>().InSingletonScope();
        }
    }
}
