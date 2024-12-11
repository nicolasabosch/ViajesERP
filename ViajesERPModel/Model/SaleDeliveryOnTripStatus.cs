using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class SaleDeliveryOnTripStatus
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryOnTripStatusID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? SaleDeliveryOnTripStatusName { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("SaleDeliveryOnTripStatus")]
    public virtual ICollection<SaleDelivery> SaleDelivery { get; } = new List<SaleDelivery>();

    [InverseProperty("SaleDeliveryOnTripStatus")]
    public virtual ICollection<TripSaleDelivery> TripSaleDelivery { get; } = new List<TripSaleDelivery>();
}
