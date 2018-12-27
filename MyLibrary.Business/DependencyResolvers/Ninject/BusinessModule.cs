using MyLibrary.Business.Abstract;
using MyLibrary.Business.Concrete;
using MyLibrary.DataAccess.Abstract;
using MyLibrary.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace MyLibrary.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAuthorService>().To<AuthorManager>().InSingletonScope();
            Bind<IAuthorDal>().To<EfAuthorDal>().InSingletonScope();

            Bind<IBookService>().To<BookManager>().InSingletonScope();
            Bind<IBookDal>().To<EfBookDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind<IPublisherService>().To<PublisherManager>().InSingletonScope();
            Bind<IPublisherDal>().To<EfPublisherDal>().InSingletonScope();
        }
    }
}
