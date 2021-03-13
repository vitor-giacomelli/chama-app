using CourseSignUp.Services.Dto.Courses;
using CourseSignUp.Services.Dto.Students;
using System.Collections.Generic;

namespace CourseSignUp.Services.Dto.Statistics
{
    public class CourseStatisticsDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int MinimumAge { get; set; }
        public int MaximumAge { get; set; }
        public decimal AverageAge { get; set; }
        public CourseDto Course { get; set; }
        public ICollection<StudentDto> Students { get; set; }
    }
}