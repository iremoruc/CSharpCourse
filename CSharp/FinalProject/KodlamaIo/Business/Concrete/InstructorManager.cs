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
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal = new EfInstructorDal();

        public void Delete(Instructor entity)
        {
            _instructorDal.Delete(entity);
        }

        public Instructor? GetById(int id)
        {
            return _instructorDal.GetById(id);
        }

        public List<Instructor>? GetList()
        {
            return _instructorDal.GetList();
        }

        public void Insert(Instructor entity)
        {
            _instructorDal.Insert(entity);
        }

        public void Update(Instructor entity)
        {
            _instructorDal.Update(entity);
        }
    }
}
