using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReadyTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
			//This is only a test for git
			//Added new feature1
            // Added another feature
			ViewBag.Message = "Something Something";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Message()
        {
            ViewBag.Message = "Some message here";
            return PartialView();
        }
    }
}