using AAerolinea.Vuelos.Domain.Interfaces;
using Aerolinea.Vuelos.Domain.Interfaces;
using Aerolinea.Vuelos.Infrastructure.Context;
using Aerolinea.Vuelos.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Vuelos.Infrastructure
{
    public static class Extensions
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {


            services.AddScoped<IVueloRepository, VueloRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();


            return services;
        }
    }
}
