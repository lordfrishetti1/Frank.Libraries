﻿using System;
using Frank.Libraries.Logging.File;
using Frank.Libraries.Logging.Sql;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.Extensions
{
    public static class LoggerFactoryExtensions
    {
        public static ILoggerFactory UseSqlLogger(this ILoggerFactory loggerFactory, IConfiguration configuration)
        {
            var sqlConfiguration = new SqlLoggerConfiguration()
            {
                LogLevel = Enum.Parse<LogLevel>(configuration[$"{nameof(SqlLoggerConfiguration)}:{nameof(SqlLoggerConfiguration.LogLevel)}"]),
                ConnectionString = configuration[$"{nameof(SqlLoggerConfiguration)}:{nameof(SqlLoggerConfiguration.ConnectionString)}"]
            };

            return AddLogger(loggerFactory, sqlConfiguration);
        }

        public static ILoggerFactory UseSqlLogger(this ILoggerFactory loggerFactory, Action<SqlLoggerConfiguration> sqlConfiguration)
        {
            var config = new SqlLoggerConfiguration();
            sqlConfiguration(config);
            return AddLogger(loggerFactory, config);
        }

        public static ILoggerFactory UseFileLogger(this ILoggerFactory loggerFactory, IConfiguration configuration)
        {
            var fileConfiguration = new FileLoggerConfiguration()
            {
                LogLevel = Enum.Parse<LogLevel>(configuration[$"{nameof(FileLoggerConfiguration)}:{nameof(FileLoggerConfiguration.LogLevel)}"]),
                Directory = configuration[$"{nameof(FileLoggerConfiguration)}:{nameof(FileLoggerConfiguration.Directory)}"]
            };

            return AddLogger(loggerFactory, fileConfiguration);
        }

        public static ILoggerFactory UseFileLogger(this ILoggerFactory loggerFactory, Action<FileLoggerConfiguration> fileConfiguration)
        {
            var config = new FileLoggerConfiguration();
            fileConfiguration(config);
            return AddLogger(loggerFactory, config);
        }

        // public static ILoggerFactory UseEntityFrameworkLogger<T>(this ILoggerFactory loggerFactory, IConfiguration configuration)
        // where T : DbContext
        // {
        //     var entityFrameworkLoggerConfiguration = new EntityFrameworkLoggerConfiguration()
        //     {
        //         LogLevel = Enum.Parse<LogLevel>(configuration[$"{nameof(EntityFrameworkLoggerConfiguration)}:{nameof(EntityFrameworkLoggerConfiguration.LogLevel)}"]),
        //     };
        //
        //     return AddLogger<T>(loggerFactory, entityFrameworkLoggerConfiguration);
        // }

        // public static ILoggerFactory UseEntityFrameworkLogger(this ILoggerFactory loggerFactory, Action<FileLoggerConfiguration> fileConfiguration)
        // {
        //     var config = new FileLoggerConfiguration();
        //     fileConfiguration(config);
        //     return AddLogger(loggerFactory, config);
        // }

        // private static ILoggerFactory AddLogger<T>(ILoggerFactory loggerFactory, EntityFrameworkLoggerConfiguration entityFrameworkLoggerConfiguration)
        // where T : DbContext
        // {
        //     loggerFactory.AddProvider(new EntityFrameworkLoggerProvider<T>(loggerFactory));
        //
        //     return loggerFactory;
        // }

        private static ILoggerFactory AddLogger(ILoggerFactory loggerFactory, FileLoggerConfiguration fileConfiguration)
        {
            if (string.IsNullOrWhiteSpace(fileConfiguration.Directory))
            {
                throw new ArgumentNullException(nameof(fileConfiguration), $"'{nameof(FileLoggerConfiguration)}.{nameof(FileLoggerConfiguration.Directory)}' cannot be null or empty");
            }

            loggerFactory.AddProvider(new FileLoggerProvider(fileConfiguration));

            return loggerFactory;
        }

        private static ILoggerFactory AddLogger(ILoggerFactory loggerFactory, SqlLoggerConfiguration sqlConfiguration)
        {
            if (string.IsNullOrWhiteSpace(sqlConfiguration.ConnectionString))
            {
                throw new ArgumentNullException(nameof(sqlConfiguration), $"'{nameof(SqlLoggerConfiguration)}.{nameof(SqlLoggerConfiguration.ConnectionString)}' cannot be null or empty");
            }

            loggerFactory.AddProvider(new SqlLoggerProvider(sqlConfiguration));

            return loggerFactory;
        }
    }
}