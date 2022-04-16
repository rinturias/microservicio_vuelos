using Aerolinea.Vuelos.Domain.Event;
using Sharedkernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Vuelos.Domain.Entities
{
    public class Vuelo : AggregateRoot<Guid>
    {
        public int codVuelo { get; private set; }
        public DateTime horaSalida { get; private set; }
        public DateTime horaLLegada { get; private set; }
        public string estado { get; private set; }
        public decimal precio { get; private set; }
        public DateTime fecha { get; private set; }
        public int codDestino { get; private set; }
        public int codOrigen { get; private set; }
        public int codAeronave { get; private set; }
        public int activo { get; private set; }

        public ICollection<TripulacionVuelo> tripulacionVuelos { get; private set; }
        public Vuelo()
        {
            Id = Guid.NewGuid();
            tripulacionVuelos = new List<TripulacionVuelo>();

        }

        public void ConsolidarEventVueloHabilitado()
        {
            var evento = new VueloHabilitado(this);
            AddDomainEvent(evento);
        }
    }
}
