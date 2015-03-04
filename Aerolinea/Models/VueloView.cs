using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aerolinea.Models.Domain.Data;

namespace Aerolinea.Models
{
    public class VueloView
    {
        public int Valor { get; set; }
        public string Clase { get; set; }
        public string NumeroVuelo { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public string Destino { get; set; }
        public string Origen { get; set; }
        public string Aeropuerto { get; set; }

    }
}