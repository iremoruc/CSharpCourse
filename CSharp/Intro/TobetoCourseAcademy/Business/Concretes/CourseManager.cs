using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager
    {
        AdoNetCourseDal adoNetCourseDal = new AdoNetCourseDal();
        public void Add(Course course)
        {           
            adoNetCourseDal.Add(course);
        }
    }
}
