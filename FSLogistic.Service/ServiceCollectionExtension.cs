using FSLogistic.Core.UoW;
using FSLogistic.Domain;
using FSLogistic.Domain.UoW;
using FSLogistic.Service.Account;
using FSLogistic.Service.Bill;
using FSLogistic.Service.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace FSLogistic.Service
{
    public static class ServiceCollectionExtension
    {
        public static void ConfigureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureDomain(configuration);

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IBillService, BillService>();

            services.AddTransient<IPrincipal>(provider =>
            {
                if (provider.GetService<IHttpContextAccessor>().HttpContext != null)
                    return provider.GetService<IHttpContextAccessor>().HttpContext.User;
                return null;
            });
        }
    }
}
