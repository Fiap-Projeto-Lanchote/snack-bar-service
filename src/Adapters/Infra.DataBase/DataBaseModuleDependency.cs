﻿using Infra.DataBase.Context;
using Infra.DataBase.Dal;
using Infra.DataBase.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.DataBase
{
    public static class DataBaseModuleDependency
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductDal, ProductDal>();

            return services;
        }
    }
}
