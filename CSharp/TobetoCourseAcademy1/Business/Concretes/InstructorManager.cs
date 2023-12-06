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
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public async Task AddAsync(Instructor instructor)
        {
            await _instructorDal.AddAsync(instructor);
        }

        public async Task<IPaginate<Instructor>> GetListAsync()
        {
            return await _instructorDal.GetListAsync();
        }
    }
}
