using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web;
using System.Collections.Specialized;

using CabernetDBContext;
using ViajesERPModel.Model;
using Microsoft.AspNetCore.Authorization;

namespace DemoCabernetNet6.Controllers
{
    [Route("api/TripEvent")]
    [ApiController]
    public class TripEventController : ControllerBase
    {
        private readonly Entities db;
        public TripEventController(Entities context)
        {
            db = context;
        }

        // POST: api/Customer
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<object>> PostCustomer(TripEvent tripEvent)
        {
            if (tripEvent == null)
            {
                return Problem("Entity set 'Entities.Customer'  is null.");
            }
            
            tripEvent.CreatedOn = DateTime.Now;
            tripEvent.LastModifiedOn = DateTime.Now;

            db.TripEvent.Add(tripEvent);
            //Entities.ProcessChildrenUpdate(db, Customer.DataTranslation.ToList());
            await db.SaveChangesAsync();

            return CreatedAtAction("GetTripEvent", new { id = tripEvent.TripEventID }, tripEvent);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TripEvent>> GetTripEvent(int id)
        {
            if (db.TripEvent == null)
            {
                return NotFound();
            }
            var tripEvent = await db.TripEvent.FindAsync(id);

            if (tripEvent == null)
            {
                return NotFound();
            }

            return tripEvent;
        }

    }
}