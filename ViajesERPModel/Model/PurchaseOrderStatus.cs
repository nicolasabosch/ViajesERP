using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class PurchaseOrderStatus
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseOrderStatusID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string PurchaseOrderStatusName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("PurchaseOrderStatus")]
    public virtual ICollection<PurchaseOrder> PurchaseOrder { get; } = new List<PurchaseOrder>();
}
