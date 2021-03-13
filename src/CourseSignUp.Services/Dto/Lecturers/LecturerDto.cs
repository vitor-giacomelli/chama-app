using CourseSignUp.Services.Dto.Courses;
using System;
using System.Collections.Generic;

namespace CourseSignUp.Services.Dto.Lecturers
{
    public class LecturerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<CourseDto> Courses { get; set; }
    }
}