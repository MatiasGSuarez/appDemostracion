using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Proxies;
using BaseRest.Core.Model.Model;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;


namespace Model
{
    public class DbModelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                              .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                              .AddJsonFile("appsettings.json")
                              .Build();
                var str = configuration.GetConnectionString("DefaultConnection");
                if (string.IsNullOrEmpty(str))
                    throw new Exception("No hay string de conexión...");

                optionsBuilder
                    .UseSqlServer(str)
                    .EnableSensitiveDataLogging()
                    .ConfigureWarnings(c => c.Log((RelationalEventId.CommandExecuting, LogLevel.Debug)));

                optionsBuilder.UseLazyLoadingProxies();
            }
        }
    }
}
