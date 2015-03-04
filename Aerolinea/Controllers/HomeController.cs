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
        IEnumerable<VueloView> origen = null;

        public HomeController()
            : this(new RepositoryEF())
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
            //var obj = mgr.BusquedaVueloOrigen();
            //return View(obj);
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
            origen = mgr.BusquedaVueloOrigen();
            return View("Index", origen);
        }


    }
}
