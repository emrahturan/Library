using System.Collections.Generic;
using MyLibrary.Business.Abstract;
using MyLibrary.Business.Utilities;
using MyLibrary.Business.ValidationRules.FluentValidation;
using MyLibrary.DataAccess.Abstract;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private readonly IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetAll();
        }

        public void Add(Author author)
        {
            ValidationTool.Validate(new AuthorValidator(), author);
            _authorDal.Add(author);
        }

        public void Update(Author author)
        {
            ValidationTool.Validate(new AuthorValidator(), author);
            _authorDal.Update(author);
        }

        public void Delete(Author author)
        {
            _authorDal.Delete(author);
        }
    }
}
