using System.Collections.Generic;
using MyLibrary.Business.Abstract;
using MyLibrary.Business.Utilities;
using MyLibrary.Business.ValidationRules.FluentValidation;
using MyLibrary.DataAccess.Abstract;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Add(Category category)
        {
            ValidationTool.Validate(new CategoryValidator(), category);
            _categoryDal.Add(category);
        }

        public void Update(Category category)
        {
            ValidationTool.Validate(new CategoryValidator(), category);
            _categoryDal.Update(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
    }
}
