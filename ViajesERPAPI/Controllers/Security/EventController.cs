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
    [Route("api/Event")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly Entities db;
        public EventController(Entities context)
        {
            db = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult GetEvent()
        {

            var eventList = (from Event in db.Event

                             select new
                             {
                                 Event.EventID,
                                 Event.EventName,

                             }).ToList();

            
            return Ok(eventList);
        }

    }
}