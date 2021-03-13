using AutoMapper;
using CourseSignUp.Adapters.Repository.Entities;
using CourseSignUp.Services.Dto.Courses;
using CourseSignUp.Services.Dto.Lecturers;
using CourseSignUp.Services.Dto.Statistics;
using CourseSignUp.Services.Dto.Students;

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

            CreateMap<Student, StudentDto>();

            CreateMap<Lecturer, LecturerDto>();

            CreateMap<CourseStatistics, CourseStatisticsDto>();
                
        }
    }
}
