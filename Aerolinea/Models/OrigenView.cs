using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aerolinea.Models
{
    public class OrigenView
    {
        public int IdOrigen { get; set; }
        public string Origen { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime HoraSalida { get; set; }
        public string Aeropuerto { get; set; }
    }
}