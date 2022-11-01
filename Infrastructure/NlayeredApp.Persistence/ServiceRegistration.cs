using Microsoft.Extensions.DependencyInjection;
using NlayeredApp.Application.Abstractions;
using NlayeredApp.Persistence.Concretes;
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
        }
    }
}
