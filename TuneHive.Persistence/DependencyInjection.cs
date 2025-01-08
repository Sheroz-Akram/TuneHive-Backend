using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using TuneHive.Application.Interfaces.Repository;
using TuneHive.Domain.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace TuneHive.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDBContext).Assembly.FullName));
            });
            services.ResolveRepositories();
            return services;
        }
        public static void ResolveRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<ApplicationUser>, Repository<ApplicationUser>>();
        }
    }
}
