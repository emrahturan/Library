using System.Collections.Generic;
using FluentValidation;
using MyLibrary.Business.Abstract;
using MyLibrary.Business.Utilities;
using MyLibrary.Business.ValidationRules.FluentValidation;
using MyLibrary.DataAccess.Abstract;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.Business.Concrete
{
    public class PublisherManager : IPublisherService
    {
        private readonly IPublisherDal _publisherDal;

        public PublisherManager(IPublisherDal publisherDal)
        {
            _publisherDal = publisherDal;
        }

        public List<Publisher> GetAll()
        {
            return _publisherDal.GetAll();
        }

        public void Add(Publisher publisher)
        {
            ValidationTool.Validate(new PublisherValidator(), publisher);
            _publisherDal.Add(publisher);
        }

        public void Update(Publisher publisher)
        {
            ValidationTool.Validate(new PublisherValidator(), publisher);
            _publisherDal.Update(publisher);
        }

        public void Delete(Publisher publisher)
        {
            _publisherDal.Delete(publisher);
        }
    }
}
