using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aerolinea.Models.Domain.Business;
using Aerolinea.Models;

namespace Aerolinea.Controllers
{
    public class HomeController : Controller
    {
        private VueloMgr mgr = null;
        internal IRepository _repo = null;
        IEnumerable<VueloView> vuelos = null;

        public HomeController()
            : this(new Repository())
        {
        }

        public HomeController(IRepository repo)
        {
            _repo = repo;
            mgr = new VueloMgr(_repo);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }


        // GET: Home
        public ActionResult Index()
        {
            vuelos = mgr.CargaFiltros();
            return View(vuelos);
        }


        [HttpPost]
        public ActionResult Search(string Origen, string Destino)
        {
            vuelos = mgr.BusquedaVuelos(Origen, Destino);
            return View("Index", vuelos);
        }

        public JsonResult SearchFly(string Origin, string Destiny)
        {
            var fly = mgr.BusquedaVuelos(Origin, Destiny);
            var query = fly.Select(x => new {

                ListaOrigen = x.ListaVuelosOrigen.Select(p=> new
                {
                    origen = p.Origen,
                    fecha = p.FechaSalida.ToShortDateString(),
                    hora = p.HoraSalida.ToShortTimeString()+" hrs.",
                    aeropuerto = p.Aeropuerto
                }),

                ListaDestino = x.ListaVuelosDestino.Select(p=> new
                {
                    destino = p.Destino,
                    fecha = p.FechaDestino.ToShortDateString(),
                    hora = p.HoraDestino.ToShortTimeString(),
                    aeropuerto = p.Aeropuerto
                })

            });
            return Json(query, JsonRequestBehavior.AllowGet);
        }


    }
}
