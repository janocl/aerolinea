using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aerolinea.Models
{
    public class ViajeView
    {
        public int Id { get; set; }
        public string Ciudad { get; set; }

        private IEnumerable<SelectListItem> lista = new List<SelectListItem>() 
        {
            new SelectListItem { Text = "Iquique", Value = "0" },
            new SelectListItem { Text = "Santiago", Value = "1" },
            new SelectListItem { Text = "Concepcion", Value = "2" },
            new SelectListItem { Text = "Valdivia", Value = "3" }
        };
        public IEnumerable<SelectListItem> listaCiudades
        {
            get { return lista; }
            set { lista = value; }
        }

        public DateTime FechaIda { get; set; }
        public DateTime FechaRegreso { get; set; }
        public int Cantidad { get; set; }
        public bool Seleccion { get; set; }
    }
}