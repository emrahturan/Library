using System.Collections.Generic;
using MyLibrary.Business.Abstract;
using MyLibrary.Business.ValidationRules.FluentValidation;
using MyLibrary.Core.Aspects.PostSharp.LogAspects;
using MyLibrary.Core.Aspects.PostSharp.ValidationAspects;
using MyLibrary.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using MyLibrary.DataAccess.Abstract;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.Business.Concrete.Managers
{
    [LogAspect(typeof(DatabaseLogger))]
    //[LogAspect(typeof(FileLogger))] optional
    public class AuthorManager : IAuthorService
    {
        private readonly IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetList();
        }

        [FluentValidationAspect(typeof(AuthorValidator))]
        public void Add(Author author)
        {
            _authorDal.Add(author);
        }

        [FluentValidationAspect(typeof(AuthorValidator))]
        public void Update(Author author)
        {
            _authorDal.Update(author);
        }

        public void Delete(Author author)
        {
            _authorDal.Delete(author);
        }
    }
}
