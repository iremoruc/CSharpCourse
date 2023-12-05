using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfCourseDal : EfGenericRepository<Course>, ICourseDal
    {
        public List<Course> GetCoursesWithNames()
        {
            using var context = new Context();
            return context.Courses.Include(x=>x.Instructor).Include(x=>x.Category).ToList();
        }
    }
}
