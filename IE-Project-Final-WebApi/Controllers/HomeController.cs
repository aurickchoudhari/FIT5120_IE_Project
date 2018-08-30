using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IE_Project_Final_WebApi.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult LightCondition()
        {
            return View();
        }

        public ActionResult SuburbCollision()
        {
            return View();
        }

        public ActionResult Speed()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
