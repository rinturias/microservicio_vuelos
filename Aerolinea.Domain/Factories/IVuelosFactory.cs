using Aerolinea.Vuelos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Vuelos.Domain.Factories
{
    public interface IVuelosFactory
    {
        Vuelo Create(long nroVuelo);
    }
}
