using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NlayeredApp.Application.Abstractions;
using NlayeredApp.Application.Repositories;
using NlayeredApp.Persistence.Concretes;
using NlayeredApp.Persistence.Context;
using NlayeredApp.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IinMemoryService, InMemoryService>();

            services.AddDbContext<NlayeredAppDbContext>(options => options.UseSqlServer(Configuration.ConnectionString)
            ,ServiceLifetime.Singleton);

            //Map
            services.AddScoped<ICustomerReadRepository,CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository,CustomerWriteRepository>();

            services.AddScoped<IOrderReadRepository,OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository,OrderWriteRepository>();

            services.AddScoped<IProductReadRepository,ProductReadRepository>();
            services.AddScoped<IProductWriteRepository,ProductWriteRepository>();
        }
    }
}
