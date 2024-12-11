using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class ProductCustomDelivery
{
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseOrderID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseReceptionItemID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    public int PurchaseDeliveryNumber { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ReceivedQuantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal OpenQuantity { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CustomDeliveryCode { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }
}
