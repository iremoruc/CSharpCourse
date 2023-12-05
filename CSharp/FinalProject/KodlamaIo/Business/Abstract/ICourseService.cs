using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        public void Insert(Course entity);
        public void Delete(Course entity);
        public void Update(Course entity);
        public List<Course>? GetList();
        public Course? GetById(int id);
        public Course GetCoursesWithNames();

    }
}
