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
using MiniProject.Models;

namespace MiniProject.Controllers
{
    public class CustomerBookingsController : ApiController
    {
        private MiniProjectContext db = new MiniProjectContext();

        // GET: api/CustomerBookings
        public IQueryable<CustomerBooking> GetCustomerBookings()
        {
            return db.CustomerBookings;
        }

        // GET: api/CustomerBookings/5
        [ResponseType(typeof(CustomerBooking))]
        public IHttpActionResult GetCustomerBooking(int id)
        {
            CustomerBooking customerBooking = db.CustomerBookings.Find(id);
            if (customerBooking == null)
            {
                return NotFound();
            }

            return Ok(customerBooking);
        }

        // PUT: api/CustomerBookings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCustomerBooking(int id, CustomerBooking customerBooking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != customerBooking.TableID)
            {
                return BadRequest();
            }

            db.Entry(customerBooking).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerBookingExists(id))
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

        // POST: api/CustomerBookings
        [ResponseType(typeof(CustomerBooking))]
        public IHttpActionResult PostCustomerBooking(CustomerBooking customerBooking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CustomerBookings.Add(customerBooking);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = customerBooking.TableID }, customerBooking);
        }

        // DELETE: api/CustomerBookings/5
        [ResponseType(typeof(CustomerBooking))]
        public IHttpActionResult DeleteCustomerBooking(int id)
        {
            CustomerBooking customerBooking = db.CustomerBookings.Find(id);
            if (customerBooking == null)
            {
                return NotFound();
            }

            db.CustomerBookings.Remove(customerBooking);
            db.SaveChanges();

            return Ok(customerBooking);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CustomerBookingExists(int id)
        {
            return db.CustomerBookings.Count(e => e.TableID == id) > 0;
        }
    }
}