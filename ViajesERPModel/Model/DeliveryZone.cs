using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class DeliveryZone
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string DeliveryZoneID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? DeliveryZoneName { get; set; }

    public int? DisplayOrder { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("DeliveryZone")]
    public virtual ICollection<Customer> Customer { get; } = new List<Customer>();

    [InverseProperty("DeliveryZone")]
    public virtual ICollection<CustomerDeliveryAddress> CustomerDeliveryAddress { get; } = new List<CustomerDeliveryAddress>();

    [InverseProperty("DeliveryZone")]
    public virtual ICollection<SaleDelivery> SaleDelivery { get; } = new List<SaleDelivery>();

    [InverseProperty("DeliveryZone")]
    public virtual ICollection<SaleOrder> SaleOrder { get; } = new List<SaleOrder>();

    [InverseProperty("DeliveryZone")]
    public virtual ICollection<Trip> Trip { get; } = new List<Trip>();

    [InverseProperty("DeliveryZone")]
    public virtual ICollection<WithdrawalOrder> WithdrawalOrder { get; } = new List<WithdrawalOrder>();
}
