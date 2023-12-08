using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
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
        private readonly IMapper _mapper;

        public InstructorManager(IInstructorDal instructorDal, IMapper mapper)
        {
            _instructorDal = instructorDal;
            _mapper = mapper;
        }

        public async Task AddAsync(CreateInstructorRequest createInstructorRequest)
        {
            var instructor = _mapper.Map<Instructor>(createInstructorRequest);
            await _instructorDal.AddAsync(instructor);
        }

        public async Task<IPaginate<GetInstructorResponse>> GetListAsync()
        {
            var instructors = await _instructorDal.GetListAsync();
            return _mapper.Map<IPaginate<GetInstructorResponse>>(instructors);
        }
    }
}
