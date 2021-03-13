using CourseSignUp.Services.Dto.Courses;
using System.Threading.Tasks;

namespace CourseSignUp.Services.DomainServices.Contracts
{
    public interface ICoursesService
    {
        CourseDto GetCourseById(int id);
        Task<bool> CreateCourse(CreateCourseDto course);
    }
}
