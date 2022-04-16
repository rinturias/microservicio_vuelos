using Aerolinea.Vuelos.Domain.Entities;
using Sharedkernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Vuelos.Domain.Event
{
    public class VueloHabilitado : DomainEvent
    {

        public VueloHabilitado(Vuelo vuelo) : base(DateTime.Now)
        {

            vueloHabilitado = vuelo;

        }
        public Vuelo vueloHabilitado { get; private set; }
    
    }
}
