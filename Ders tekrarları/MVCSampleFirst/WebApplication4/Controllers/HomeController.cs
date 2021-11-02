using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(34, "İstanbul"),
                new KeyValuePair<int, string>(1, "Adana"),
                new KeyValuePair<int, string>(6, "Ankara")
            };


            ViewBag.Message = "Hello World";
            ViewBag.Message = "Hello Bayburt";
            ViewBag.Data = data;

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

            return View();
        }
    }
}