using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlInventario.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
              return  RedirectToAction("Index","Principal");
            }
            
             return View();
            
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Inventarios Tec.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacto";

            return View();
        }
    }
}