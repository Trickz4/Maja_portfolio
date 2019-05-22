using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Maja_testiranje.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About me";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My contact page.";

            return View();
        }
        public ActionResult Illustrations()
        {
            ViewBag.Message = "Illustrations";

            return View();
        }
        public ActionResult Work()
        {
            ViewBag.Message = "Work";

            return View();
        }
    }
}