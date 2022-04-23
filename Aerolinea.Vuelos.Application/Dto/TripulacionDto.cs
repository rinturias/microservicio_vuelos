using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Vuelos.Application.Dto
{
    public class TripulacionDto
    {

        public long codVuelo { get;  set; }
        public long codTripulacion { get; set; }
        public int codEmpleado { get;  set; }
        public string estado { get;  set; }
        public int activo { get;  set; }


    }
}
