using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aerolinea.Models.Domain.Data;
using System.Web.Mvc;

namespace Aerolinea.Models
{
    public class VueloView
    {
        public int IdVuelo { get; set; }
        public List<OrigenView> ListaVuelosOrigen { get; set; }
        public List<DestinoView> ListaVuelosDestino { get; set; }
        public IEnumerable<SelectListItem> ItemsOrigen { get; set; }
        public IEnumerable<SelectListItem> ItemsDestino { get; set; }

    }
}