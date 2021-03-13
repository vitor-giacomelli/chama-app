using CourseSignUp.Services.Dto.Courses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Services.Dto.Students
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<CourseDto> Courses { get; set; }
    }
}
