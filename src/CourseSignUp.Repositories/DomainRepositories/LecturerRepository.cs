using AutoMapper;
using CourseSignUp.Adapters.Repository;
using CourseSignUp.Adapters.Repository.Entities;
using CourseSignUp.Adapters.Repository.Repositories;
using CourseSignUp.Services.Dto.Lecturers;
using CourseSignUp.Services.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseSignUp.Repositories.DomainRepositories
{
    public class LecturerRepository : EntityRepository<Lecturer>, ILecturerRepository
    {
        private readonly ModelContext _modelContext;
        private readonly IMapper _mapper;

        public LecturerRepository(ModelContext context, IMapper mapper) : base(context)
        {
            _modelContext = context;
            _mapper = mapper;
        }
        public Task CreateLecturer(LecturerDto lecturer)
        {
            throw new NotImplementedException();
        }
    }
}
