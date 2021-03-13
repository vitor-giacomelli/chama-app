using CourseSignUp.Common.Domain.Model;
using System;
using System.Collections.Generic;

namespace CourseSignUp.Adapters.Repository.Entities
{
    public class Lecturer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
