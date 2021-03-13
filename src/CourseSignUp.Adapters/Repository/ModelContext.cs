using CourseSignUp.Adapters.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseSignUp.Adapters.Repository
{
    public class ModelContext : BaseDbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options)
          : base(options)
        {
        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Lecturer> Lecturer { get; set; }
        public virtual DbSet<Student> Student { get; set; }
    }
}
