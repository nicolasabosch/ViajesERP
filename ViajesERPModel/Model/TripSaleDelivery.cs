using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("TripID", "SaleDeliveryID")]
public partial class TripSaleDelivery
{
    [Key]
    public int TripID { get; set; }

    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryID { get; set; } = null!;

    public int DisplayOrder { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryOnTripStatusID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleDeliveryRejectReasonID { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? SaleDeliveryDeliveryRemarks { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? SaleDeliveryOnTripRemarks { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("SaleDeliveryID")]
    [InverseProperty("TripSaleDelivery")]
    public virtual SaleDelivery SaleDelivery { get; set; } = null!;

    [ForeignKey("SaleDeliveryOnTripStatusID")]
    [InverseProperty("TripSaleDelivery")]
    public virtual SaleDeliveryOnTripStatus SaleDeliveryOnTripStatus { get; set; } = null!;

    [ForeignKey("SaleDeliveryRejectReasonID")]
    [InverseProperty("TripSaleDelivery")]
    public virtual SaleDeliveryRejectReason? SaleDeliveryRejectReason { get; set; }

    [ForeignKey("TripID")]
    [InverseProperty("TripSaleDelivery")]
    public virtual Trip Trip { get; set; } = null!;
}
