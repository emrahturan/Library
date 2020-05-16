using System.Collections.Generic;
using MyLibrary.Business.Abstract;
using MyLibrary.Business.ValidationRules.FluentValidation;
using MyLibrary.Core.CrossCuttingConcerns.Caching.Microsoft;
using MyLibrary.DataAccess.Abstract;
using MyLibrary.Entities.Concrete;
using MyLibrary.Core.Aspects.PostSharp.CacheAspects;
using MyLibrary.Core.Aspects.PostSharp.LogAspects;
using MyLibrary.Core.Aspects.PostSharp.ValidationAspects;
using MyLibrary.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

namespace MyLibrary.Business.Concrete.Managers
{
    [LogAspect(typeof(DatabaseLogger))]
    //[LogAspect(typeof(FileLogger))] optional
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Book> GetAll()
        {
            new FileLogger().Info("example");
            return _bookDal.GetList();
        }

        public List<Book> GetBookById(int id)
        {
            return _bookDal.GetList(p => p.Id == id);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [FluentValidationAspect(typeof(BookValidator))]
        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [FluentValidationAspect(typeof(BookValidator))]
        public void Update(Book book)
        {
            _bookDal.Update(book);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }
    }
}
