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
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal = new EfCourseDal();

        public void Delete(Course entity)
        {
            _courseDal.Delete(entity);
        }

        public Course? GetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public List<Course>? GetList()
        {
            return _courseDal.GetList();
        }

        public void Insert(Course entity)
        {
            _courseDal.Insert(entity);
        }

        public void Update(Course entity)
        {
            _courseDal.Update(entity);
        }
    }
}
