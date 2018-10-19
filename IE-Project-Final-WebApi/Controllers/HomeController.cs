using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IE_Project_Final_WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult Index()
        {
            //ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Stats()
        {
            return View();
        }

        public ActionResult Statistics()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Feedback_wildlife()
        {
            return View();
        }

        public ActionResult NaturalActivities()
        {
            return View();
        }
       
    }
}
