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
    //[Route("api/Values")]

    [ApiController]
    public class SaleDeliveryController : ControllerBase
    {
        private readonly Entities db;
        public SaleDeliveryController(Entities context)
        {
            db = context;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/SaleDeliveryOnTripStatus")]

        public ActionResult GetSaleDeliveryOnTripStatus()
        {
            var SaleDeliveryOnTripStatusList = (from SaleDeliveryOnTripStatus in db.SaleDeliveryOnTripStatus

                                                select new
                                                {
                                                    SaleDeliveryOnTripStatus.SaleDeliveryOnTripStatusID,
                                                    SaleDeliveryOnTripStatus.SaleDeliveryOnTripStatusName,

                                                }).ToList();

            return Ok(SaleDeliveryOnTripStatusList);
        }
        [Route("api/SaleDeliveryRejectReason")]
        [AllowAnonymous]
        [HttpGet]
        public ActionResult GetSaleDeliveryRejectReason()
        {
            var SaleDeliveryRejectReasonList = (from SaleDeliveryRejectReason in db.SaleDeliveryRejectReason

                                                select new
                                                {
                                                    SaleDeliveryRejectReason.SaleDeliveryRejectReasonID,
                                                    SaleDeliveryRejectReason.SaleDeliveryRejectReasonName,

                                                }).ToList();

            return Ok(SaleDeliveryRejectReasonList);
        }

    }
}