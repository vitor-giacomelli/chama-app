using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using System;
using System.Collections;
using System.Linq;
using System.Reflection;

namespace CourseSignUp.Common.Logging
{
    public static class Logging
    {
        public static void InitializeSerilog(IConfiguration configuration, string source)
        {
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .Enrich.WithProperty("Source", source)
                .Enrich.With<ExceptionDataEnricher>()
                .CreateLogger();
            Serilog.Debugging.SelfLog.Enable(Console.Error);
        }

        /// <summary>
        /// Initialize Serilog's configuration using EntryAssembly's name
        /// como source
        /// </summary>
        /// <param name="configuration"></param>
        public static void InitializeSerilog(IConfiguration configuration)
        {
            InitializeSerilog(configuration,
                Assembly.GetEntryAssembly().GetName().Name);
        }

        public class ExceptionDataEnricher : ILogEventEnricher
        {
            public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
            {
                if (logEvent.Exception == null ||
                    logEvent.Exception.Data == null ||
                    logEvent.Exception.Data.Count == 0) return;

                var dataDictionary = logEvent.Exception.Data
                    .Cast<DictionaryEntry>()
                    .Where(e => e.Key is string)
                    .ToDictionary(e => (string)e.Key, e => e.Value);

                var property = propertyFactory.CreateProperty("ExceptionData", dataDictionary, destructureObjects: true);

                logEvent.AddPropertyIfAbsent(property);
            }
        }
    }
}
