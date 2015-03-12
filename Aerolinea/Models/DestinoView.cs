using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aerolinea.Models
{
    public class DestinoView
    {
        public string Destino { get; set; }
        public DateTime FechaDestino { get; set; }
        public DateTime HoraDestino { get; set; }
        public string Aeropuerto { get; set; }
    }
}