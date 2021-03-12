using CourseSignUp.Services.Dto.Courses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseSignUp.Services.DomainServices.Contracts
{
    public interface ICoursesService
    {
        Task<CourseDto> GetAsync(string id);
    }
}
