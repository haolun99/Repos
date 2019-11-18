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
using WebApiCRUDLogics.Models;

namespace WebApiCRUDLogics.Controllers
{
    public class CarBrandsController : ApiController
    {
        private carbrandEntities db = new carbrandEntities();

        // GET: api/CarBrands
        [ResponseType(typeof(IEnumerable<CarBrand>))]
        //[Route("api/GetCarBrands")]
        public IQueryable<CarBrand> GetCarBrands()
        {
            return db.CarBrands;
        }

        // GET: api/CarBrands/5
        [ResponseType(typeof(CarBrand))]
        //[Route("api/GetCarBrands")]
        public IHttpActionResult GetCarBrand(int id)
        {
            CarBrand carBrand = db.CarBrands.Find(id);
            if (carBrand == null)
            {
                return NotFound();
            }

            return Ok(carBrand);
        }

        // PUT: api/CarBrands/5
        [ResponseType(typeof(CarBrand))]
        [Route("api/PutCarBrand")]
        [HttpPut]
        public IHttpActionResult PutCarBrand(int id, [FromBody]CarBrand carBrand)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carBrand.ID)
            {
                return BadRequest();
            }

            db.Entry(carBrand).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarBrandExists(id))
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

        // POST: api/CarBrands
        [Route("api/PostCarBrand")]
        [ResponseType(typeof(CarBrand))]
        public IHttpActionResult PostCarBrand(CarBrand carBrand)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CarBrands.Add(carBrand);
            db.SaveChanges();

            return CreatedAtRoute("api/PostCarBrand/", new { id = carBrand.ID }, carBrand);
        }

        // DELETE: api/CarBrands/5
        [Route("api/DeleteCarBrand")]
        [ResponseType(typeof(CarBrand))]
        public IHttpActionResult DeleteCarBrand(int id)
        {
            CarBrand carBrand = db.CarBrands.Find(id);
            if (carBrand == null)
            {
                return NotFound();
            }

            db.CarBrands.Remove(carBrand);
            db.SaveChanges();

            return Ok(carBrand);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        [Route("api/CarBrandExists")]
        private bool CarBrandExists(int id)
        {
            return db.CarBrands.Count(e => e.ID == id) > 0;
        }
    }
}