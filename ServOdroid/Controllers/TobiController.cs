namespace ServOdroid.Controllers
{
    using Manager_Tobi;
    using Models;
    using System.Web.Mvc;

    public class TobiController : Controller
    {
        public ActionResult Tobi()
        {
            TobiViewModel model = new TobiViewModel();

            //System.Web.HttpContext.Current.Session["TobiSession"] = TobiHub.TobiInstance;
            
            //ViewBag.Tobi = ViewData["TobiSession"] = System.Web.HttpContext.Current.Session["TobiSession"] as Tobi;
            //ViewBag.Tobi = Context.Session.GetTobi("TobiAssitant");
            return View(model);
        }
    }
}