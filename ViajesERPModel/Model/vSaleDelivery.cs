using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vSaleDelivery
{
    [StringLength(15)]
    [Unicode(false)]
    public string SourceID { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string SourceName { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? SaleOrderDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryID { get; set; } = null!;

    public int SaleDeliveryNumber { get; set; }

    public int? SaleDeliveryNoteLegalNumber { get; set; }

    public int SaleOrderNumber { get; set; }

    [Column(TypeName = "date")]
    public DateTime RequestedDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string BusinessUnitName { get; set; } = null!;

    public int? Units { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? Meters { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? Kilos { get; set; }

    public int? Pieces { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryStatusID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? SaleDeliveryStatusName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CustomerLegalName { get; set; }

    [StringLength(200)]
    public string? StateName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DistrictName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ZipCode { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? WarehouseID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? WarehouseName { get; set; }

    [Column(TypeName = "date")]
    public DateTime? SaleDeliveryDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime DeliveryDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? PreparedWarehouseGroupID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PreparedWarehouseGroupName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? CurrentWarehouseGroupID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CurrentWarehouseGroupName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? CarrierID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CarrierName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CarrierAddress { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CarrierPhone { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleRepresentativeID { get; set; }

    [StringLength(201)]
    public string? SaleRepresentativeName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string DeliveryZoneID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string DeliveryZoneName { get; set; } = null!;

    [StringLength(5000)]
    [Unicode(false)]
    public string? DeliveryInstruction { get; set; }

    public int? TripID { get; set; }

    [Column(TypeName = "date")]
    public DateTime? TripDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? FreightID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? FreightName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? TripStatusID { get; set; }

    [StringLength(200)]
    public string? TripStatusName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryOnTripStatusID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? SaleDeliveryOnTripStatusName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleDeliveryRejectReasonID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SaleDeliveryRejectReasonName { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? SaleDeliveryOnTripRemarks { get; set; }

    [Column(TypeName = "date")]
    public DateTime? RealDeliveryDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? CreationDate { get; set; }
}
