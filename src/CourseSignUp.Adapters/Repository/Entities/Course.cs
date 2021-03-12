using CourseSignUp.Common.Domain.Model;
using System.Collections.Generic;

namespace CourseSignUp.Adapters.Repository.Entities
{
    public partial class Course : IEntity
    {
        public int Id { get; set; }
        public int LecturerId { get; set; }
        public int MaximumStudents { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
