using FSLogistic.Domain;
using FSLogistic.Service.Product;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Service
{
    public static class ServiceCollectionExtension
    {
        public static void ConfigureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureDomain(configuration);

            services.AddScoped<IProductService, ProductService>();



            //services.AddTransient<IPrincipal>(provider =>
            //{
            //    if (provider.GetService<IHttpContextAccessor>().HttpContext != null)
            //        return provider.GetService<IHttpContextAccessor>().HttpContext.User;
            //    return null;
            //});
        }
    }
}
