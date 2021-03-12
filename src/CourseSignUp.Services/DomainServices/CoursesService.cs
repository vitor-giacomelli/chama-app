using CourseSignUp.Services.DomainServices.Contracts;
using CourseSignUp.Services.Dto.Courses;
using CourseSignUp.Services.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseSignUp.Services.DomainServices
{
    public class CoursesService : ICoursesService
    {
        private readonly ICoursesRepository _coursesRepository;

        public CoursesService(ICoursesRepository coursesRepository)
        {
            _coursesRepository = coursesRepository;
        }

        public Task<CourseDto> GetAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
