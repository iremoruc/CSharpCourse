using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal = new EfCategoryDal();
        public void Delete(Category entity)
        {
          _categoryDal.Delete(entity);
        }

        public Category? GetById(int id)
        {
           return _categoryDal.GetById(id);
        }

        public List<Category>? GetList()
        {
           return _categoryDal.GetList();
        }

        public void Insert(Category entity)
        {
            _categoryDal.Insert(entity);
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
