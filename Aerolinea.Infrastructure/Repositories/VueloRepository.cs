using AAerolinea.Vuelos.Domain.Interfaces;
using Aerolinea.Vuelos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Vuelos.Infrastructure.Repositories
{
    public class VueloRepository : IVueloRepository
    {
        public Task CreateAsync(Vuelo obj)
        {
            Console.WriteLine($"Insertando el vuelo { obj.codVuelo }");
            return Task.CompletedTask;
        }

        public Task FindByIdAsync(Guid id)
        {
            Console.WriteLine($"Retornando el vuelo { id }");

            return null;
        }

 

        public Task UpdateAsync(Vuelo obj)
        {
            Console.WriteLine($"Actualizando el vuelo { obj.codVuelo }");

            return Task.CompletedTask;
        }
    }
}
