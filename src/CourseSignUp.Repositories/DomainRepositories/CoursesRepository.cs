using AutoMapper;
using CourseSignUp.Adapters.Repository;
using CourseSignUp.Adapters.Repository.Entities;
using CourseSignUp.Adapters.Repository.Repositories;
using CourseSignUp.Services.Dto.Courses;
using CourseSignUp.Services.IRepository;
using Serilog;
using System;
using System.Linq;
using System.Threading.Tasks;

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
            Log.Logger.Information("Initializing course fetch with Id {0} at {1}", id, DateTime.Now);
            var courseEntity = _modelContext.Course.Where(x => x.Id == id).AsQueryable();
            var returnCourseDto = _mapper.ProjectTo<CourseDto>(courseEntity).ToList();
            Log.Logger.Information("Finalizing course fetch with Id {0} at {1}", id, DateTime.Now);
            return returnCourseDto.FirstOrDefault();
        }

        public async Task CreateCourse (CreateCourseDto course)
        {
            try
            {
                Log.Logger.Information("Initializing course creation for {0} at {1}", course.Name, DateTime.Now);
                var newEntity = _mapper.ProjectTo<Course>((IQueryable)course);
                await AddRangeAndSaveAsync(newEntity);
                Log.Logger.Information("Finalizing course creation for {0} at {1}", course.Name, DateTime.Now);
            }
            catch (Exception ex)
            {
                Log.Logger.Error("Exception launched when creating course {0} at {1}: {2}", course.Name, DateTime.Now, ex.Message);
                throw;
            }
        }
    }
}
