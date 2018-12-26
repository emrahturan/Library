using MyLibrary.Entities.Concrete;
using System.Collections.Generic;

namespace MyLibrary.Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        List<Book> GetBookById(int id);
        void Add(Book book);
        void Delete(Book book);
        void Update(Book book);
    }
}
