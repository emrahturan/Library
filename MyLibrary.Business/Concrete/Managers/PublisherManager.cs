using System.Collections.Generic;
using MyLibrary.Business.Abstract;
using MyLibrary.Business.ValidationRules.FluentValidation;
using MyLibrary.Core.Aspects.PostSharp.CacheAspects;
using MyLibrary.Core.Aspects.PostSharp.LogAspects;
using MyLibrary.Core.Aspects.PostSharp.ValidationAspects;
using MyLibrary.Core.CrossCuttingConcerns.Caching.Microsoft;
using MyLibrary.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using MyLibrary.DataAccess.Abstract;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.Business.Concrete.Managers
{
    [LogAspect(typeof(DatabaseLogger))]
    //[LogAspect(typeof(FileLogger))] optional
    public class PublisherManager : IPublisherService
    {
        private readonly IPublisherDal _publisherDal;

        public PublisherManager(IPublisherDal publisherDal)
        {
            _publisherDal = publisherDal;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Publisher> GetAll()
        {
            return _publisherDal.GetList();
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [FluentValidationAspect(typeof(PublisherValidator))]
        public void Add(Publisher publisher)
        {
            _publisherDal.Add(publisher);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [FluentValidationAspect(typeof(PublisherValidator))]
        public void Update(Publisher publisher)
        {
            _publisherDal.Update(publisher);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(Publisher publisher)
        {
            _publisherDal.Delete(publisher);
        }
    }
}
