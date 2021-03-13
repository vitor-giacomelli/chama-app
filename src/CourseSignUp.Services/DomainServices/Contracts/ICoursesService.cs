using CourseSignUp.Services.Dto.Courses;

namespace CourseSignUp.Services.DomainServices.Contracts
{
    public interface ICoursesService
    {
        CourseDto GetCourseById(int id);
    }
}
