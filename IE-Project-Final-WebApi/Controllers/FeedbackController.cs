using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IE_Project_Final_WebApi.Models;

namespace IE_Project_Final_WebApi.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        public ActionResult Feedback()
        {
            //List<string> result = new List<string>();
            //result.Add("Success in saving the life");
            //result.Add("Failure in saving the life");
            return View();
        }

        // GET: Feedback/Details/5
        public ActionResult SaveRecord(Wildlife_Feedback model)
        {
            try {

                JashWildlifeEntities db = new JashWildlifeEntities();

                Wildlife_Feedback w = new Wildlife_Feedback();

                w.Result = model.Result;
                w.Name = model.Name;
                w.Description = model.Description;

                db.Wildlife_Feedback.Add(w);

                db.SaveChanges();

            }

            catch(Exception ex)
            {
                throw ex;
            }
            

            return RedirectToAction("List_Feedback");
        }

        public ActionResult List_Feedback()
        {
            using (JashWildlifeEntities cd = new JashWildlifeEntities())
            {
                return View(cd.Wildlife_Feedback.ToList());
            }
        }
       


    }
}
