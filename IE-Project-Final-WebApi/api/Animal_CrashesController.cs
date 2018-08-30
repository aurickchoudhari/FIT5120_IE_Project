using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using IE_Project_Final_WebApi.Models;

namespace IE_Project_Final_WebApi.api
{
    public class Animal_CrashesController : ApiController
    {
        private wildlifeaidEntities1 db = new wildlifeaidEntities1();

        // GET: api/Animal_Crashes
        public IQueryable<Animal_Crashes> GetAnimal_Crashes()
        {
            return db.Animal_Crashes;
        }

        // GET: api/Animal_Crashes/5
        [ResponseType(typeof(Animal_Crashes))]
        public IHttpActionResult GetAnimal_Crashes(int id)
        {
            Animal_Crashes animal_Crashes = db.Animal_Crashes.Find(id);
            if (animal_Crashes == null)
            {
                return NotFound();
            }

            return Ok(animal_Crashes);
        }

        // PUT: api/Animal_Crashes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAnimal_Crashes(int id, Animal_Crashes animal_Crashes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != animal_Crashes.ID)
            {
                return BadRequest();
            }

            db.Entry(animal_Crashes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Animal_CrashesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Animal_Crashes
        [ResponseType(typeof(Animal_Crashes))]
        public IHttpActionResult PostAnimal_Crashes(Animal_Crashes animal_Crashes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Animal_Crashes.Add(animal_Crashes);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = animal_Crashes.ID }, animal_Crashes);
        }

        // DELETE: api/Animal_Crashes/5
        [ResponseType(typeof(Animal_Crashes))]
        public IHttpActionResult DeleteAnimal_Crashes(int id)
        {
            Animal_Crashes animal_Crashes = db.Animal_Crashes.Find(id);
            if (animal_Crashes == null)
            {
                return NotFound();
            }

            db.Animal_Crashes.Remove(animal_Crashes);
            db.SaveChanges();

            return Ok(animal_Crashes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Animal_CrashesExists(int id)
        {
            return db.Animal_Crashes.Count(e => e.ID == id) > 0;
        }
    }
}