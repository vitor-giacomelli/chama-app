using CourseSignUp.Adapters.Repository.Entities;
using CourseSignUp.Common.Persistence;
using CourseSignUp.Services.Dto.Courses;
using System.Threading.Tasks;

namespace CourseSignUp.Services.IRepository
{
    public interface ICoursesRepository : IRepository<Course>
    {
        CourseDto GetCourseById(int id);
        Task CreateCourse(CreateCourseDto course);
    }
}
