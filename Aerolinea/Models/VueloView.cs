using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aerolinea.Models.Domain.Data;

namespace Aerolinea.Models
{
    public class VueloView
    {
        public List<Origen> Ida { get; set; }
        public List<Destino> Llegada { get; set; }
        public List<Vuelo> NumeroVuelo { get; set; }

    }
}