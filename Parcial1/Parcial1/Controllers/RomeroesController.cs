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
using Parcial1.Models;

namespace Parcial1.Controllers
{
    public class RomeroesController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Romeroes
        [Authorize]
        public IQueryable<Romero> GetRomeroes()
        {
            return db.Romeroes;
        }

        // GET: api/Romeroes/5
        [Authorize]
        [ResponseType(typeof(Romero))]
        public IHttpActionResult GetRomero(int id)
        {
            Romero romero = db.Romeroes.Find(id);
            if (romero == null)
            {
                return NotFound();
            }

            return Ok(romero);
        }

        // PUT: api/Romeroes/5
        [Authorize]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRomero(int id, Romero romero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != romero.RomeroID)
            {
                return BadRequest();
            }

            db.Entry(romero).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RomeroExists(id))
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

        // POST: api/Romeroes
        [Authorize]
        [ResponseType(typeof(Romero))]
        public IHttpActionResult PostRomero(Romero romero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Romeroes.Add(romero);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = romero.RomeroID }, romero);
        }

        // DELETE: api/Romeroes/5
        [Authorize]
        [ResponseType(typeof(Romero))]
        public IHttpActionResult DeleteRomero(int id)
        {
            Romero romero = db.Romeroes.Find(id);
            if (romero == null)
            {
                return NotFound();
            }

            db.Romeroes.Remove(romero);
            db.SaveChanges();

            return Ok(romero);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RomeroExists(int id)
        {
            return db.Romeroes.Count(e => e.RomeroID == id) > 0;
        }
    }
}