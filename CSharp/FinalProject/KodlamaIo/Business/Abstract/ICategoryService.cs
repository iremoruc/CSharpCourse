using Entity.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        public void Insert(Category entity);
        public void Delete(Category entity);
        public void Update(Category entity);
        public List<Category>? GetList();
        public Category? GetById(int id);

    }
}
