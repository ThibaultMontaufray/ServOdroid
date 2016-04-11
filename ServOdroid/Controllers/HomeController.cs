namespace ServOdroid.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About ServOdroid : un cerveau pour nos robots.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Notre travail vous intéresse ? Contactez nous à l'adresse suivante : ";

            return View();
        }
        public ActionResult StandBye()
        {
            ViewBag.Message = "Aïe Aïe Aïe ! Cette page n'est pas disponible !!! ";

            return View();
        }
    }
}