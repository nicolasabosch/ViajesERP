using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class zViejavPurchaseOrderTotal
{
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseOrderID { get; set; } = null!;

    public int PurchaseOrderNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? PurchaseOrderName { get; set; }

    [Column(TypeName = "date")]
    public DateTime RequestedDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? PromisedArrivalDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string BusinessUnitName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CurrencyName { get; set; } = null!;

    [StringLength(200)]
    public string VendorName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? SeasonName { get; set; }

    [StringLength(200)]
    public string ProductFamilyName { get; set; } = null!;

    [StringLength(200)]
    public string ProductName { get; set; } = null!;

    [StringLength(200)]
    public string UnitOfMeasureName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal RequestedQuantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? RequestedUnits { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal UnitFOBPrice { get; set; }

    public int? PurchaseDeliveryNumber { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PurchaseDeliveryName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PurchaseDeliveryDescription { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ShipmentDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ArrivalDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DeliveryDate { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ForwarderCode { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SealCode { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CustomDeliveryCode { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DeliveredQuantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DeliveredUnits { get; set; }

    public int? PurchaseReceptionNumber { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PurchaseReceptionName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? WarehouseName { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ReceptionDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ReceivedQuantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ReceivedUnits { get; set; }

    [Unicode(false)]
    public string? CODUN_CONT { get; set; }

    [Unicode(false)]
    public string? COMENTARIOS { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? PurchaseDeliveryID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? PurchaseReceptionID { get; set; }
}
