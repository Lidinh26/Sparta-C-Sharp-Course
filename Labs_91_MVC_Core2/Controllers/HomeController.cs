using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Labs_91_MVC_Core2.Models;

namespace Labs_91_MVC_Core2.Controllers
{
    public class HomeController : Controller
    {
        List<string> list = new List<string>();
        

        public IActionResult Index()
        {
            var instance = new LisModel();
            instance.myList1.Add("Hello");
            instance.myList1.Add("Hello");
            instance.myList1.Add("Hello");
            instance.myList2.Add("Li");
            instance.myList2.Add("Li");
            instance.myList2.Add("Li");

            list.Add("This is my List");
            list.Add("For my webpage");
            ViewBag.MyList = list;
            return View("LiPage",instance);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
