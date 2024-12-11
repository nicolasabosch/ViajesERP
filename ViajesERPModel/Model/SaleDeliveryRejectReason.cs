using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class SaleDeliveryRejectReason
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryRejectReasonID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? SaleDeliveryRejectReasonName { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("SaleDeliveryRejectReason")]
    public virtual ICollection<SaleDelivery> SaleDelivery { get; } = new List<SaleDelivery>();

    [InverseProperty("SaleDeliveryRejectReason")]
    public virtual ICollection<TripSaleDelivery> TripSaleDelivery { get; } = new List<TripSaleDelivery>();

    [InverseProperty("SaleDeliveryRejectReason")]
    public virtual ICollection<WithdrawalOrder> WithdrawalOrder { get; } = new List<WithdrawalOrder>();
}
