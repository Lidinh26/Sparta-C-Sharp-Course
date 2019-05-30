using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Labs_67_Razor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewData["Message2"] = "And a second message";

            return View();
        }

        public ActionResult RazorHelloWorld()
        {
            ViewData["Message2"] = "And a second message";
            ViewBag.Message = "Second Razor page.";

            var passthisstring = "Send some data from controller to view";

            return View("RazerHelloWorld", passthisstring);
        }
    }
}