using AutoMapper;
using CourseSignUp.Adapters.Repository.Entities;
using CourseSignUp.Services.Dto.Courses;

namespace CourseSignUp.Services.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Course, CourseDto>()
                .ForMember(dest => dest.Capacity,
                    opts => opts.MapFrom(src => src.MaximumStudents))
                .ForMember(dest => dest.NumberOfStudents,
                    opts => opts.MapFrom(src => src.Students.Count));
        }
    }
}
