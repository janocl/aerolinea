using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aerolinea.Models.Domain.Data;

namespace Aerolinea.Models
{
    public class VueloView
    {
        public List<OrigenView> ListaOrigen { get; set; }
        public List<DestinoView> ListaDestino { get; set; }
 

    }
}