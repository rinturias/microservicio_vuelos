using Sharedkernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Vuelos.Domain.Entities
{
    public class TripulacionVuelo:Entity<Guid>
    {
        public Guid codTripulacion { get; private set; }
        public int codEmpleado { get; private set; }
        public string estado { get; private set; }
        public int activo { get; private set; }

       

        internal TripulacionVuelo(Guid codTripulacion, int codEmpleado, string estado, int activo)
        {
            Id = Guid.NewGuid();
            this.codTripulacion = codTripulacion;
            this.codEmpleado = codEmpleado;
            this.estado = estado;
            this.activo = activo;
        }
    }
}
