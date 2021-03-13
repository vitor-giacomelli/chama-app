using CourseSignUp.Services.DomainServices.Contracts;
using CourseSignUp.Services.Dto.Courses;
using CourseSignUp.Services.IRepository;
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

        public CourseDto GetCourseById(int id)
        {
            return _coursesRepository.GetCourseById(id);
        }

        public async Task<bool> CreateCourse(CreateCourseDto course)
        {
            await _coursesRepository.CreateCourse(course);
            return true;
        }
    }
}
