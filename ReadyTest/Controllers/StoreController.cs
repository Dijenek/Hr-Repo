using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReadyTest.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        public string Info(string genre)
        {
            return "Nesto from Info metode iz zanra:" + genre;
        }

        public string ReturnGenreId(int id)
        {
            string returnMessage = "Genre id" + id ;
            return returnMessage;
        }

        public ActionResult About()
        {
            //ViewBag.Marko = "Fora do mora";
            return View("~/Views/Home/Contact.cshtml");
        }
    }
}