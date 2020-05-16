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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [FluentValidationAspect(typeof(CategoryValidator))]
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [FluentValidationAspect(typeof(CategoryValidator))]
        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
    }
}
