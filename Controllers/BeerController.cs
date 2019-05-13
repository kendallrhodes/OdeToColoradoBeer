using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToColoradoBeer.Controllers
{
    [Authorize]
    public class BeerController : Controller
    {
        //
        // GET: /Brewery/
          
        public ActionResult Search(string name = "IPA")
        {
            var message = Server.HtmlEncode(name);
            return Content(message);
        }
    }
}
