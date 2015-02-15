using Aerolinea.Models.Domain.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aerolinea.Models;

namespace Aerolinea.Controllers
{
    public class VueloController : Controller
    {

        private VueloMgr mgr = null;
        internal IRepository _repo = null;

        public VueloController()
            : this(new RepositoryEF())
        {
        }

        public VueloController(IRepository repo)
        {
            _repo = repo;
            mgr = new VueloMgr(_repo);
        }

        // GET: Vuelo
        public ActionResult Index()
        {
            var obj = mgr.BusquedaDeVuelos();
            return View(obj);
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

        public ActionResult Search()
        {
            var obj = mgr.BusquedaDeVuelos();
            return View(obj);
        }


    }
}