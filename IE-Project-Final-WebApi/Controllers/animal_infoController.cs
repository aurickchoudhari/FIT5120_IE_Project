using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IE_Project_Final_WebApi.Models;

namespace IE_Project_Final_WebApi.Controllers
{
    public class animal_infoController : Controller
    {
        // GET: animal_info
        public ActionResult animal_info_Index()
        {
            using (animal_information animal = new animal_information())
            {
                return View(animal.C_Total_of_species__.ToList());
            }

        }

        // GET: animal_info/Details/5   
        public ActionResult Details(int id)
        {
            using (animal_information animal = new animal_information())
            {
                return View(animal.C_Total_of_species__.Where(x => x.ID == id).FirstOrDefault());
            }




        }

        // GET: animal_info/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: animal_info/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: animal_info/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: animal_info/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: animal_info/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: animal_info/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Options()
        {
            return View();
        }

        public ActionResult Extinction_of_mammals()
        {
            return View();
        }
    }
}
