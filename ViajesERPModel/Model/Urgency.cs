using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Urgency
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string UrgencyID { get; set; } = null!;

    [StringLength(200)]
    public string UrgencyName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("Urgency")]
    public virtual ICollection<SaleDeliveryNote> SaleDeliveryNote { get; } = new List<SaleDeliveryNote>();

    [InverseProperty("Urgency")]
    public virtual ICollection<SaleOrder> SaleOrder { get; } = new List<SaleOrder>();
}
