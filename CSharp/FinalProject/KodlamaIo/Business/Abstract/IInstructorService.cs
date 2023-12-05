using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        public void Insert(Instructor entity);
        public void Delete(Instructor entity);
        public void Update(Instructor entity);
        public List<Instructor>? GetList();
        public Instructor? GetById(int id);
    }
}
