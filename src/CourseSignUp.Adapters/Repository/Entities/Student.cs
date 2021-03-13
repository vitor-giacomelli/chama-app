using CourseSignUp.Common.Domain.Model;
using System;
using System.Collections.Generic;

namespace CourseSignUp.Adapters.Repository.Entities
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

    }
}
