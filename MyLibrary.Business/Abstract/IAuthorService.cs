using System.Collections.Generic;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.Business.Abstract
{
    public interface IAuthorService
    {
        List<Author> GetAll();
        void Add(Author author);
        void Delete(Author author);
        void Update(Author author);
    }
}
