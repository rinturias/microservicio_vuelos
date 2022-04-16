using Aerolinea.Vuelos.Domain.Event;
using Aerolinea.Vuelos.Domain.ValueObjects;
using Sharedkernel.Core;
using Sharedkernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Vuelos.Domain.Entities
{
    public class Vuelo : AggregateRoot<Guid>
    {
        public long codVuelo { get; private set; }
        public DateTime horaSalida { get; private set; }
        public DateTime horaLLegada { get; private set; }
        public string estado { get; private set; }
        public PrecioValue precio { get; private set; }
        public DateValueObject  fecha { get; private set; }
        public int codDestino { get; private set; }
        public int codOrigen { get; private set; }
        public int codAeronave { get; private set; }
        public int activo { get; private set; }

        public ICollection<TripulacionVuelo> tripulacionVuelos { get; private set; }



        public Vuelo()
        {
            Id = Guid.NewGuid();
            this.tripulacionVuelos = new List<TripulacionVuelo>();
        }

        public Vuelo(long codVuelo)
        {
            

            this.codVuelo = codVuelo;
            this.tripulacionVuelos = new List<TripulacionVuelo>();

        }

        public void AgregarItem(long codVuelo, DateTime horaSalida, DateTime horaLLegada, string estado, PrecioValue precio, DateValueObject fecha, int codDestino, int codOrigen, int codAeronave, int activo ,
            long codTripulacion, int codEmpleado, string estadoTri, int activoTri)
        {

            var detalleTripulacion = tripulacionVuelos.FirstOrDefault(x => x.codTripulacion == codTripulacion && x.codVuelo==codVuelo);
            if (detalleTripulacion is null)
            {
                detalleTripulacion = new TripulacionVuelo(codTripulacion, codEmpleado, estadoTri, activoTri,codVuelo);
                tripulacionVuelos.Add(detalleTripulacion);
            }
            else
            {
                detalleTripulacion.ModificarTripulacionVuelo(estadoTri, activoTri);
            }


            this.codVuelo = codVuelo;
            this.horaSalida = horaSalida;
            this.horaLLegada = horaLLegada;
            this.estado = estado;
            this.precio = precio;
            this.fecha = fecha;
            this.codDestino = codDestino;
            this.codOrigen = codOrigen;
            this.codAeronave = codAeronave;
            this.activo = activo;

            AddDomainEvent(new VueloHabilitado(this));
           
        }

        public void ConsolidarEventVueloHabilitado()
        {
            var evento = new VueloHabilitado(this);
            AddDomainEvent(evento);
        }
    }
}
