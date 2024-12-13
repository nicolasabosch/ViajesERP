using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web;
using System.Collections.Specialized;
using ViajesERPModel.Model;
using CabernetDBContext;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using System.Security.Policy;

namespace DemoCabernetNet6.Controllers
{
    [Route("api/TripEvent")]
    [ApiController]
    public class TripEvent : ControllerBase
    {
        private readonly Entities db;
        public TripEvent(Entities context)
        {
            db = context;
        }

        
        //[HttpGet]
        //public ActionResult GetTripEvent(string id)
        //{
            
        //}
        
        //[HttpPost]
        //public ActionResult PostTripEvent()
        //{
        
        //}

        
    }
}