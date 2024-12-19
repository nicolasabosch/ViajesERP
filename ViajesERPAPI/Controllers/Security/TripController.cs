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

        // GET api/Language


        // GET api/Language/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public ActionResult GetTrip(int id)
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

                        where Trip.TripID == id
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



                        }).FirstOrDefault();




            if (trip == null)
            {
               return NotFound();

            }

            dynamic record = trip.ToExpando();


            record.TripEvent = (from TripEvent in db.TripEvent
                                from File in db.File.Where(x => x.FileID == TripEvent.FileID).DefaultIfEmpty()
                                join Event in db.Event on TripEvent.EventID equals Event.EventID
                                where TripEvent.TripID == id select new
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
                                    Preview = File == null ? false : previewList.Contains(File.FileName.ToLower().Substring(File.FileName.ToLower().IndexOf("."))),

                                }


                                ).ToList();
            record.TripSaleDelivery = (from TripSaleDelivery in db.TripSaleDelivery
                                       join vSaleDelivery in db.vSaleDelivery on TripSaleDelivery.SaleDeliveryID equals vSaleDelivery.SaleDeliveryID
                                       where TripSaleDelivery.TripID == id
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
                                          where TripWithdrawalOrder.TripID == id
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
                                     where TripSaleRetail.TripID == id
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

        // PUT api/Language/5
        //[HttpPut("{id}")]
        //public ActionResult PutLanguage(string id, Language language)
        //{
        //    ModelState.Clear();
        //    Extensions.ClearReferences(language);
        //    TryValidateModel(language);
        //    if (ModelState.IsValid && id == language.LanguageID)
        //    {
        //        db.Entry(language).State = EntityState.Modified;
        //        Entities.ProcessChildrenUpdate(db, language.DataTranslation.ToList());
        //        try
        //        {
        //            db.SaveChanges();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            return NotFound();
        //        }

        //        return NoContent();
        //    }
        //    else
        //    {
        //        return BadRequest(ModelState);
        //    }
        //}

        // POST api/Language
        //[HttpPost]
        //public ActionResult<Language> PostLanguage(Language language)
        //{
        //    ModelState.Clear();
        //    Extensions.ClearReferences(language);
        //    TryValidateModel(language);
        //    if (ModelState.IsValid)
        //    {
        //        db.Language.Add(language);
        //        Entities.ProcessChildrenUpdate(db, language.DataTranslation.ToList());
        //        try
        //        {
        //            db.SaveChanges();
        //        }
        //        catch (DbUpdateException)
        //        {
        //            if (LanguageExists(language.LanguageID))
        //            {
        //                return Conflict();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return CreatedAtAction("GetLanguage", new
        //        {
        //            id = language.LanguageID
        //        }

        //        , language);
        //    }
        //    else
        //    {
        //        return BadRequest(ModelState);
        //    }
        //}

       
    }
}