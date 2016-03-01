using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace knockoutApp2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "knockoutApp2 Information";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "For more information, please contact us at:";

            return View();
        }
    }
}