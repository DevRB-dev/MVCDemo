using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return  typeof(Controller).Assembly.GetName().Version.ToString()+ "Hello this is Rahul Bhandari!!";
             
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your Application description Page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact Page.";

            return View();
        }
    }
}