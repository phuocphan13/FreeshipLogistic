using FSLogistic.Core.Consts;
using FSLogistic.Core.Repositories;
using FSLogistic.Core.UoW;
using FSLogistic.Domain.Models;
using FSLogistic.Domain.Repositories;
using FSLogistic.Domain.UoW;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Domain
{
    public static class ServiceCollectionExtension
    {
        public static void ConfigureDomain(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FreeShipLogisticResourceContext>(options =>
                options.UseSqlServer(Const.ConnectionStringResource));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IRepository<Product>, Repository<Product>>();
            services.AddScoped<IRepository<Summary>,Repository<Summary>>();
        }
    }
}
