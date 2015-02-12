using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aerolinea.Models
{
    public class OrigenView
    {
        public int Id { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime HoraSalida { get; set; }
        public int IdCiudad { get; set; }
    }
}