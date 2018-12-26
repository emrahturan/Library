using System.Collections.Generic;
using MyLibrary.Business.Abstract;
using MyLibrary.Business.Utilities;
using MyLibrary.Business.ValidationRules.FluentValidation;
using MyLibrary.DataAccess.Abstract;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.Business.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public List<Book> GetBookById(int id)
        {
            return _bookDal.GetAll(p => p.Id == id);
        }

        public void Add(Book book)
        {
            ValidationTool.Validate(new BookValidator(), book);
            _bookDal.Add(book);
        }

        public void Update(Book book)
        {
            ValidationTool.Validate(new BookValidator(), book);
            _bookDal.Update(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }
    }
}
