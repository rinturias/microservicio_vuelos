using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Vuelos.Application.Dto
{
    public class VuelosDto
    {
        public long codVuelo { get;  set; }
        public DateTime horaSalida { get;  set; }
        public DateTime horaLLegada { get;  set; }
        public string estado { get;  set; }
        public decimal precio { get;  set; }
        public DateTime fecha { get;  set; }
        public int codDestino { get;  set; }
        public int codOrigen { get;  set; }
        public int codAeronave { get;  set; }
        public int activo { get;  set; }






    }
}
