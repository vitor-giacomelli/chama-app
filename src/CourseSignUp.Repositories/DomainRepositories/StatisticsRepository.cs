using AutoMapper;
using CourseSignUp.Adapters.Repository;
using CourseSignUp.Adapters.Repository.Entities;
using CourseSignUp.Adapters.Repository.Repositories;
using CourseSignUp.Services.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Repositories.DomainRepositories
{
    public class StatisticsRepository : EntityRepository<CourseStatistics>, IStatisticsRepository
    {
        private readonly ModelContext _modelContext;
        private readonly IMapper _mapper;

        public StatisticsRepository(ModelContext context, IMapper mapper) : base(context)
        {
            _modelContext = context;
            _mapper = mapper;
        }
    }
}
