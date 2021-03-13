using CourseSignUp.Services.Dto.Students;

namespace CourseSignUp.Services.Dto.Courses
{
    public class SignUpToCourseDto
    {
        public string CourseId { get; set; }
        public StudentDto Student { get; set; }
    }
}