using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Adapters.Repository
{
    public class BaseDbContext : DbContext
    {
        protected BaseDbContext(DbContextOptions options)
           : base(options)
        {
        }

        public static readonly ILoggerFactory DebugLoggerFactory
            = LoggerFactory.Create(builder => { builder.SetMinimumLevel(LogLevel.Debug); });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder
                .UseLoggerFactory(DebugLoggerFactory)
                .EnableSensitiveDataLogging();
        }        
    }
}
