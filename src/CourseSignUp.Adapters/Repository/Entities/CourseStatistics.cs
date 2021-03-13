using System.Collections.Generic;

namespace CourseSignUp.Adapters.Repository.Entities
{
    public class CourseStatistics
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int MinimumAge { get; set; }
        public int MaximumAge { get; set; }
        public decimal AverageAge { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}