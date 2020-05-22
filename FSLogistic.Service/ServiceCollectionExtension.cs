using FSLogistic.Domain;
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
            //services.AddScoped<IDetailService, DetailService>();
            //services.AddScoped<IOwnerService, OwnerService>();
            //services.AddScoped<IDriverService, DriverService>();
            //services.AddScoped<IVehicleService, VehicleService>();
            //services.AddScoped<IExcelService, ExcelService>();
            //services.AddScoped<IOverviewService, OverviewService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<ICompanyService, CompanyService>();
            //services.AddTransient<IPrincipal>(provider =>
            //{
            //    if (provider.GetService<IHttpContextAccessor>().HttpContext != null)
            //        return provider.GetService<IHttpContextAccessor>().HttpContext.User;
            //    return null;
            //});
        }
    }
}
