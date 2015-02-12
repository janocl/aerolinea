using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aerolinea.Models
{
    public class DestinoView
    {
        public int Id { get; set; }
        public DateTime FechaLlegada { get; set; }
        public DateTime HoraLlegada { get; set; }
        public int IdCiudad { get; set; }
    }
}