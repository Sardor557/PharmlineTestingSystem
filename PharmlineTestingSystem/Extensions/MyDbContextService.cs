﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PharmlineTestingSystem.Database;

namespace PharmlineTestingSystem.Extensions
{
    public static class MyDbContextService
    {
        public static void AddMyDatabaseService(this IServiceCollection services, IConfiguration conf)
        {
            var connStr = conf.GetConnectionString("ConnectionString");
            services.AddDbContext<MyDbContext>(o =>
            {
                o.UseNpgsql(connStr,
                    b => b.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery))
                .EnableDetailedErrors()
                .EnableSensitiveDataLogging()
                .UseSnakeCaseNamingConvention()
                .EnableServiceProviderCaching();
            });
        }

        public static void UpdateMigrateDatabase(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<MyDbContext>())
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}
