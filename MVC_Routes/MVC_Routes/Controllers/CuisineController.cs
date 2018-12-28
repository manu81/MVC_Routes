using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Routes.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Search(string name)
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var nameParam = RouteData.Values["name"];

            var result = String.Format("{0}:{1} {2}", controller, action, name);
            return Content(result);
        }
    }
}