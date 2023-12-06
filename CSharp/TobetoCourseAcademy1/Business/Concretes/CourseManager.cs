using Business.Abstracts;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public async Task AddAsync(Course course)
        {
            await _courseDal.AddAsync(course);
        }

        public async Task<IPaginate<Course>> GetListAsync()
        {
            return await _courseDal.GetListAsync();
        }
    }
}
