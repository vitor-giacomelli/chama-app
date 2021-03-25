using CourseSignUp.Adapters.Repository.Entities;
using CourseSignUp.Common.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Services.IRepository
{
    public interface IStatisticsRepository : IRepository<CourseStatistics>
    {
    }
}
