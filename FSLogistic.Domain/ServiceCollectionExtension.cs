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
            //services.AddDbContext<MotoManagementContext>(options =>
            //    options.UseSqlServer("Server=.\\LUCIFER;Database=MotoManagement;User Id=resourceadmin;Password=123456;Trusted_Connection=False;"));

            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IRepository<Company>, Repository<Company>>();
            //services.AddScoped<IRepository<Owner>, Repository<Owner>>();
            //services.AddScoped<IRepository<Vehicle>, Repository<Vehicle>>();
            //services.AddScoped<IRepository<Driver>, Repository<Driver>>();
            //services.AddScoped<IRepository<OwnerVehicleDriver>, Repository<OwnerVehicleDriver>>();
            //services.AddScoped<IRepository<Account>, Repository<Account>>();
        }
    }
}
