using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TalentManagement.Application.Repositories;
using TalentManagement.Domain.Common.GenericRepository;
using TalentManagement.Domain.Common.Interfaces;
using TalentManagement.Infrastructure.Persistence.Common;
using TalentManagement.Infrastructure.Persistence.Context;
using TalentManagement.Infrastructure.Persistence.Repositories;
using TalentManagement.Infrastructure.Seeders;

namespace TalentManagement.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            //Scopped DI
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IApplicationSeeder, ApplicationSeeder>();
            services.AddScoped<ISkillSeeder, SkillSeeder>();


            //Repository DI
            services.AddScoped<IEmployeeProfileRepository, EmployeeProfileRepository>();
            services.AddScoped<IMenteeProfileRepository, MenteeProfileRepository>();

        }
    }
}
