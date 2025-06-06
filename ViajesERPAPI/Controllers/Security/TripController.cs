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
    [Route("api/Trip")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly Entities db;
        public LanguageController(Entities context)
        {
            db = context;
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public ActionResult GetTrip(string id)
        {
            var previewList = new[] { ".jpeg", ".jpg", ".png", ".gif", ".bmp" };

            var trip = (from Trip in db.Trip
                        join TripStatus in db.TripStatus on Trip.TripStatusID equals TripStatus.TripStatusID
                        join TripType in db.TripType on Trip.TripTypeID equals TripType.TripTypeID
                        join WarehouseGroup in db.WarehouseGroup on Trip.WarehouseGroupID equals WarehouseGroup.WarehouseGroupID
                        from Destination in db.WarehouseGroup.Where(X => X.WarehouseGroupID == Trip.DestinationWarehouseGroupID).DefaultIfEmpty()
                        from DeliveryZone in db.DeliveryZone.Where(X => X.DeliveryZoneID == Trip.DeliveryZoneID).DefaultIfEmpty()
                        from VehicleType in db.VehicleType.Where(X => X.VehicleTypeID == Trip.VehicleTypeID).DefaultIfEmpty()
                        from Freight in db.Freight.Where(X => X.FreightID == Trip.FreightID).DefaultIfEmpty()

                        where Trip.TripCode == id
                        select new
                        {
                            Trip.TripID,
                            Trip.TripDate,
                            Trip.TripStatusID,
                            TripStatus.TripStatusName,
                            Trip.WarehouseGroupID,
                            WarehouseGroup.WarehouseGroupName,
                            Trip.DeliveryZoneID,
                            DeliveryZone.DeliveryZoneName,
                            Trip.FreightID,
                            Freight.FreightName,
                            Trip.DriverName,
                            Trip.PlateName,
                            Trip.TripTypeID,
                            TripType.TripTypeName,
                            Trip.DestinationWarehouseGroupID,
                            DestinationWarehouseGroupName = Destination.WarehouseGroupName,
                            Trip.VehicleTypeID,
                            VehicleType.VehicleTypeName,
                            Trip.TripCode




                        }).FirstOrDefault();




            if (trip == null)
            {
                return NotFound();

            }

            var tripID = trip.TripID;
            dynamic record = trip.ToExpando();


            record.TripEvent = (from TripEvent in db.TripEvent
                                from File in db.File.Where(x => x.FileID == TripEvent.FileID).DefaultIfEmpty()
                                join Event in db.Event on TripEvent.EventID equals Event.EventID
                                where TripEvent.TripID == tripID
                                select new
                                {
                                    TripEvent.TripEventID,
                                    TripEvent.TripID,
                                    TripEvent.CreatedOn,
                                    TripEvent.Latitude,
                                    TripEvent.Longitude,
                                    TripEvent.FileID,
                                    TripEvent.SourceID,
                                    TripEvent.SaleDeliveryID,
                                    TripEvent.EventID,
                                    Event.EventName,
                                    File.FileName,
                                    Preview = File == null ? false : previewList.Contains(File.FileName.ToLower().Substring(File.FileName.ToLower().IndexOf("."))),

                                }


                                ).ToList();
            record.TripSaleDelivery = (from TripSaleDelivery in db.TripSaleDelivery
                                       join vSaleDelivery in db.vSaleDelivery on TripSaleDelivery.SaleDeliveryID equals vSaleDelivery.SaleDeliveryID
                                       where TripSaleDelivery.TripID == tripID
                                       orderby TripSaleDelivery.DisplayOrder
                                       select new
                                       {
                                           TripSaleDelivery.TripID,
                                           TripSaleDelivery.SaleDeliveryID,
                                           vSaleDelivery.SourceID,
                                           vSaleDelivery.SourceName,
                                           vSaleDelivery.SaleDeliveryNumber,
                                           vSaleDelivery.SaleDeliveryNoteLegalNumber,
                                           vSaleDelivery.SaleOrderNumber,
                                           vSaleDelivery.CustomerID,
                                           vSaleDelivery.CustomerName,
                                           vSaleDelivery.BusinessUnitName,
                                           vSaleDelivery.Units,
                                           vSaleDelivery.Meters,
                                           vSaleDelivery.Kilos,
                                           vSaleDelivery.Pieces,
                                           vSaleDelivery.SaleDeliveryStatusID,
                                           vSaleDelivery.CustomerLegalName,
                                           vSaleDelivery.StateName,
                                           vSaleDelivery.DistrictName,
                                           vSaleDelivery.ZipCode,
                                           vSaleDelivery.Address,
                                           vSaleDelivery.Phone,
                                           vSaleDelivery.DeliveryDate,
                                           vSaleDelivery.WarehouseID,
                                           vSaleDelivery.WarehouseName,
                                           vSaleDelivery.PreparedWarehouseGroupID,
                                           vSaleDelivery.PreparedWarehouseGroupName,
                                           vSaleDelivery.CurrentWarehouseGroupID,
                                           vSaleDelivery.CurrentWarehouseGroupName,
                                           vSaleDelivery.CarrierID,
                                           vSaleDelivery.CarrierName,
                                           vSaleDelivery.CarrierAddress,
                                           vSaleDelivery.CarrierPhone,
                                           vSaleDelivery.SaleRepresentativeID,
                                           vSaleDelivery.SaleRepresentativeName,
                                           vSaleDelivery.DeliveryZoneID,
                                           vSaleDelivery.DeliveryZoneName,
                                           vSaleDelivery.DeliveryInstruction,
                                           TripSaleDelivery.SaleDeliveryOnTripStatusID,
                                           vSaleDelivery.SaleDeliveryOnTripStatusName,
                                           vSaleDelivery.SaleDeliveryRejectReasonName,
                                           TripSaleDelivery.DisplayOrder,
                                           vSaleDelivery.RealDeliveryDate,
                                           TripSaleDelivery.SaleDeliveryRejectReasonID,
                                           TripSaleDelivery.SaleDeliveryDeliveryRemarks,
                                           TripSaleDelivery.SaleDeliveryOnTripRemarks,
                                           TripSaleDelivery.LastModifiedOn,
                                           EntityStatus = "U"

                                       }).ToList();

            record.TripWithdrawalOrder = (from TripWithdrawalOrder in db.TripWithdrawalOrder
                                          join vSaleDelivery in db.vSaleDelivery on TripWithdrawalOrder.WithdrawalOrderID equals vSaleDelivery.SaleDeliveryID
                                          where TripWithdrawalOrder.TripID == tripID
                                          orderby TripWithdrawalOrder.DisplayOrder
                                          select new
                                          {
                                              TripWithdrawalOrder.TripID,
                                              vSaleDelivery.SourceID,
                                              vSaleDelivery.SourceName,
                                              vSaleDelivery.SaleDeliveryID,
                                              TripWithdrawalOrder.WithdrawalOrderID,
                                              vSaleDelivery.SaleDeliveryNumber,
                                              vSaleDelivery.SaleDeliveryNoteLegalNumber,
                                              vSaleDelivery.SaleOrderNumber,
                                              vSaleDelivery.CustomerID,
                                              vSaleDelivery.CustomerName,
                                              vSaleDelivery.BusinessUnitName,
                                              vSaleDelivery.Units,
                                              vSaleDelivery.Meters,
                                              vSaleDelivery.Kilos,
                                              vSaleDelivery.Pieces,
                                              vSaleDelivery.SaleDeliveryStatusID,
                                              vSaleDelivery.CustomerLegalName,
                                              vSaleDelivery.StateName,
                                              vSaleDelivery.DistrictName,
                                              vSaleDelivery.ZipCode,
                                              vSaleDelivery.Address,
                                              vSaleDelivery.Phone,
                                              vSaleDelivery.DeliveryDate,
                                              vSaleDelivery.WarehouseID,
                                              vSaleDelivery.WarehouseName,
                                              vSaleDelivery.PreparedWarehouseGroupID,
                                              vSaleDelivery.PreparedWarehouseGroupName,
                                              vSaleDelivery.CurrentWarehouseGroupID,
                                              vSaleDelivery.CurrentWarehouseGroupName,
                                              vSaleDelivery.CarrierID,
                                              vSaleDelivery.CarrierName,
                                              vSaleDelivery.CarrierAddress,
                                              vSaleDelivery.CarrierPhone,
                                              vSaleDelivery.SaleRepresentativeID,
                                              vSaleDelivery.SaleRepresentativeName,
                                              vSaleDelivery.DeliveryZoneID,
                                              vSaleDelivery.DeliveryZoneName,
                                              vSaleDelivery.DeliveryInstruction,
                                              TripWithdrawalOrder.SaleDeliveryOnTripStatusID,
                                              vSaleDelivery.SaleDeliveryOnTripStatusName,
                                              vSaleDelivery.SaleDeliveryRejectReasonName,
                                              TripWithdrawalOrder.DisplayOrder,
                                              vSaleDelivery.RealDeliveryDate,
                                              TripWithdrawalOrder.SaleDeliveryRejectReasonID,
                                              TripWithdrawalOrder.SaleDeliveryDeliveryRemarks,
                                              TripWithdrawalOrder.SaleDeliveryOnTripRemarks,
                                              TripWithdrawalOrder.LastModifiedOn,
                                              EntityStatus = "U"

                                          }).ToList();
            record.TripSaleRetail = (from TripSaleRetail in db.TripSaleRetail
                                     join vSaleDelivery in db.vSaleDelivery on TripSaleRetail.SaleRetailID equals vSaleDelivery.SaleDeliveryID
                                     where TripSaleRetail.TripID == tripID
                                     orderby TripSaleRetail.DisplayOrder
                                     select new
                                     {
                                         TripSaleRetail.TripID,
                                         vSaleDelivery.SourceID,
                                         vSaleDelivery.SourceName,
                                         vSaleDelivery.SaleDeliveryID,
                                         TripSaleRetail.SaleRetailID,
                                         vSaleDelivery.SaleDeliveryNumber,
                                         vSaleDelivery.SaleDeliveryNoteLegalNumber,
                                         vSaleDelivery.SaleOrderNumber,
                                         vSaleDelivery.CustomerID,
                                         vSaleDelivery.CustomerName,
                                         vSaleDelivery.BusinessUnitName,
                                         vSaleDelivery.Units,
                                         vSaleDelivery.Meters,
                                         vSaleDelivery.Kilos,
                                         vSaleDelivery.Pieces,
                                         vSaleDelivery.SaleDeliveryStatusID,
                                         vSaleDelivery.CustomerLegalName,
                                         vSaleDelivery.StateName,
                                         vSaleDelivery.DistrictName,
                                         vSaleDelivery.ZipCode,
                                         vSaleDelivery.Address,
                                         vSaleDelivery.Phone,
                                         vSaleDelivery.DeliveryDate,
                                         vSaleDelivery.WarehouseID,
                                         vSaleDelivery.WarehouseName,
                                         vSaleDelivery.PreparedWarehouseGroupID,
                                         vSaleDelivery.PreparedWarehouseGroupName,
                                         vSaleDelivery.CurrentWarehouseGroupID,
                                         vSaleDelivery.CurrentWarehouseGroupName,
                                         vSaleDelivery.CarrierID,
                                         vSaleDelivery.CarrierName,
                                         vSaleDelivery.CarrierAddress,
                                         vSaleDelivery.CarrierPhone,
                                         vSaleDelivery.SaleRepresentativeID,
                                         vSaleDelivery.SaleRepresentativeName,
                                         vSaleDelivery.DeliveryZoneID,
                                         vSaleDelivery.DeliveryZoneName,
                                         vSaleDelivery.DeliveryInstruction,
                                         TripSaleRetail.SaleDeliveryOnTripStatusID,
                                         vSaleDelivery.SaleDeliveryOnTripStatusName,
                                         vSaleDelivery.SaleDeliveryRejectReasonName,
                                         TripSaleRetail.DisplayOrder,
                                         vSaleDelivery.RealDeliveryDate,
                                         TripSaleRetail.SaleDeliveryRejectReasonID,
                                         TripSaleRetail.SaleDeliveryDeliveryRemarks,
                                         TripSaleRetail.SaleDeliveryOnTripRemarks,
                                         TripSaleRetail.LastModifiedOn,
                                         EntityStatus = "U"


                                     }).ToList();

            return Ok(record);
        }


        [AllowAnonymous]
        [HttpPut]
        public ActionResult UpdateTrip([FromBody] dynamic input)
        {
            var SaleDeliveryOnTripStatusID = input.SaleDeliveryOnTripStatusID.ToString();
            var SaleDeliveryOnTripRemarks = input.SaleDeliveryOnTripRemarks.ToString();
            var SaleDeliveryRejectReasonID = input.SaleDeliveryRejectReasonID.ToString();
            var SourceID = input.SourceID.ToString();
            int TripID = int.Parse(input.TripID.ToString());


            switch (SourceID)
            {
                case "SaleDelivery":
                    string SaleDeliveryID = input.SaleDeliveryID.ToString();
                    var TripSaleDelivery = db.TripSaleDelivery.Where(x => x.TripID == TripID && x.SaleDeliveryID == SaleDeliveryID).FirstOrDefault();
                    if (TripSaleDelivery != null)
                    {
                        TripSaleDelivery.SaleDeliveryOnTripStatusID = SaleDeliveryOnTripStatusID;
                        TripSaleDelivery.SaleDeliveryOnTripRemarks = SaleDeliveryOnTripRemarks;
                        
                        if(SaleDeliveryOnTripStatusID == "Rejected")
                        {
                            TripSaleDelivery.SaleDeliveryRejectReasonID = SaleDeliveryRejectReasonID;
                        }
                        else
                        {
                            TripSaleDelivery.SaleDeliveryRejectReasonID = null;
                        }
                        //TripSaleDelivery.SaleDeliveryRejectReasonID = SaleDeliveryRejectReasonID;
                        db.SaveChanges();
                    }
                    break;

                case "WithdrawalOrder":
                    string WithdrawalOrderID = input.WithdrawalOrderID.ToString();
                    var TripWithdrawalOrder = db.TripWithdrawalOrder.Where(x => x.TripID == TripID && x.WithdrawalOrderID == WithdrawalOrderID).FirstOrDefault();
                    if (TripWithdrawalOrder != null)
                    {
                        TripWithdrawalOrder.SaleDeliveryOnTripStatusID = SaleDeliveryOnTripStatusID;
                        TripWithdrawalOrder.SaleDeliveryOnTripRemarks = SaleDeliveryOnTripRemarks;
                        if (SaleDeliveryOnTripStatusID == "Rejected")
                        {
                            TripWithdrawalOrder.SaleDeliveryRejectReasonID = SaleDeliveryRejectReasonID;
                        }
                        else
                        {
                            TripWithdrawalOrder.SaleDeliveryRejectReasonID = null;
                        }
                        db.SaveChanges();
                    }
                    break;

                case "SaleRetail":
                    string SaleRetailID = input.SaleRetailID.ToString();
                    var TripSaleRetail = db.TripSaleRetail.Where(x => x.TripID == TripID && x.SaleRetailID == SaleRetailID).FirstOrDefault();
                    if (TripSaleRetail != null)
                    {
                        TripSaleRetail.SaleDeliveryOnTripStatusID = SaleDeliveryOnTripStatusID;
                        TripSaleRetail.SaleDeliveryOnTripRemarks = SaleDeliveryOnTripRemarks;
                        if (SaleDeliveryOnTripStatusID == "Rejected")
                        {
                            TripSaleRetail.SaleDeliveryRejectReasonID = SaleDeliveryRejectReasonID;
                        }
                        else
                        {
                            TripSaleRetail.SaleDeliveryRejectReasonID = null;
                        }
                        db.SaveChanges();
                    }
                    break;

                default:
                    return BadRequest("Invalid source ID.");
            }


            return NoContent();
        }

    }
}