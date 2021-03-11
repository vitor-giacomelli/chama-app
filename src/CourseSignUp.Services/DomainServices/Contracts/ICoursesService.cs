using CourseSignUp.Services.Dto.Courses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Services.DomainServices.Contracts
{
    public interface ICoursesService
    {
        CourseDto Get(string id);
    }
}
