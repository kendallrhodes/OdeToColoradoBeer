using OdeToColoradoBeer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToColoradoBeer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controlller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            var message = String.Format("{0}::{1} {2}", controller, action, id);

            ViewBag.Message = message;

            return View();
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.WebsiteName = "OdeToColoradoBeer";
            model.Location = "Denver, Colorado";
            model.Name = "Kendall Rhodes";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "OdeToColoradoBeer";

            return View();
        }


        public string controller { get; set; }
    }
}
