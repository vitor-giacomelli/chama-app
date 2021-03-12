using AutoMapper;
using CourseSignUp.Adapters.Repository;
using CourseSignUp.Adapters.Repository.Entities;
using CourseSignUp.Adapters.Repository.Repositories;
using CourseSignUp.Services.Dto.Courses;
using CourseSignUp.Services.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseSignUp.Repositories.DomainRepositories
{
    public class CoursesRepository : EntityRepository<Course>, ICoursesRepository
    {
        private readonly ModelContext _modelContext;
        private readonly IMapper _mapper;
        public CoursesRepository(ModelContext context, IMapper mapper) : base(context)
        {
            _modelContext = context;
            _mapper = mapper;
        }

        public CourseDto GetCourseById(int id)
        {
            var courseEntity = _modelContext.Course.Where(x => x.Id == id).AsQueryable();
            var returnCourseDto = _mapper.ProjectTo<CourseDto>(courseEntity).ToList();
            return returnCourseDto.FirstOrDefault();
        }
    }
}
