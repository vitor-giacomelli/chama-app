using CourseSignUp.Adapters.Repository;
using CourseSignUp.Adapters.Repository.Entities;
using CourseSignUp.Adapters.Repository.Repositories;
using CourseSignUp.Services.Dto.Courses;
using CourseSignUp.Services.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Repositories.DomainRepositories
{
    public class CoursesRepository : EntityRepository<Course>, ICoursesRepository
    {
        private readonly ModelContext _modelContext;
        public CoursesRepository(ModelContext context) : base(context)
        {
            _modelContext = context;       
        }

        public CourseDto GetCourseById(int id)
        {
            var courseEntity = _modelContext.Course.Find(id);
        }
    }
}
