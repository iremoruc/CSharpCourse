using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CreateCategoryRequest>().ReverseMap(); //karşılıklı birbirlerinin yerine geçebilir.
            CreateMap<Category, UpdateCategoryRequest>().ReverseMap(); 
            CreateMap<Category, CreatedCategoryResponse>().ReverseMap();
            //CreateMap<Paginate<Category>, GetCategoryResponse>().ReverseMap();
            CreateMap<IPaginate<Category>, IPaginate<GetCategoryResponse>>()
            .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));

            CreateMap<Course, CreateCourseRequest>().ReverseMap(); 
            CreateMap<Course, UpdateCourseRequest>().ReverseMap(); 
            CreateMap<Course, CreatedCourseResponse>().ReverseMap(); 
            CreateMap<Course, GetCoursesResponse>().ReverseMap(); 

            CreateMap<Instructor, CreateInstructorRequest>().ReverseMap();
            CreateMap<Instructor, UpdateInstructorRequest>().ReverseMap();
            CreateMap<Instructor, CreatedInstructorResponse>().ReverseMap();
            CreateMap<Instructor, GetInstructorResponse>().ReverseMap();
            

        }
    }
}
