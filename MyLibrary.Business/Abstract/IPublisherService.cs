using System.Collections.Generic;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.Business.Abstract
{
    public interface IPublisherService
    {
        List<Publisher> GetAll();
        void Add(Publisher publisher);
        void Delete(Publisher publisher);
        void Update(Publisher publisher);
    }
}
