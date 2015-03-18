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

        // GET: Home
        public ActionResult Index()
        {
            return View();
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

        [HttpPost]
        public ActionResult Search()
        {
            vuelos = mgr.BusquedaVuelos();
            return View("Index", vuelos);
        }

        [HttpPost]
        public ActionResult Filters()
        {
            return View();
        }


    }
}
