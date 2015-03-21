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
using PickersTunes;
using PickersTunes.Models;

namespace PickersTunes.Controllers
{
    public class TunesController : ApiController
    {
        private static TuneContext _db = new TuneContext();

        // GET: api/Tunes
        public IQueryable<Tune> GetTunes()
        {
            return _db.Tunes;
        }

        // GET: api/Tunes/5
        [ResponseType(typeof(Tune))]
        public IHttpActionResult GetTune(int id)
        {
            Tune tune = _db.Tunes.Find(id);
            if (tune == null)
            {
                return NotFound();
            }

            return Ok(tune);
        }

        // PUT: api/Tunes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTune(int id, Tune tune)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tune.TuneId)
            {
                return BadRequest();
            }

            _db.Entry(tune).State = EntityState.Modified;

            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TuneExists(id))
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

        // POST: api/Tunes
        [ResponseType(typeof(Tune))]
        public IHttpActionResult PostTune(Tune tune)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _db.Tunes.Add(tune);
            _db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tune.TuneId }, tune);
        }

        // DELETE: api/Tunes/5
        [ResponseType(typeof(Tune))]
        public IHttpActionResult DeleteTune(int id)
        {
            Tune tune = _db.Tunes.Find(id);
            if (tune == null)
            {
                return NotFound();
            }

            _db.Tunes.Remove(tune);
            _db.SaveChanges();

            return Ok(tune);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TuneExists(int id)
        {
            return _db.Tunes.Count(e => e.TuneId == id) > 0;
        }
    }
}