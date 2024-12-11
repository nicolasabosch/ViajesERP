using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class PickingOrderItem
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PickingOrderItemID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string PickingOrderID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string SaleOrderItemID { get; set; } = null!;

    /// <summary>
    /// Solicitado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal PickingQuantity { get; set; }

    /// <summary>
    /// Solicitado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal PickingUnits { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("PickingOrderID")]
    [InverseProperty("PickingOrderItem")]
    public virtual PickingOrder PickingOrder { get; set; } = null!;

    [ForeignKey("SaleOrderItemID")]
    [InverseProperty("PickingOrderItem")]
    public virtual SaleOrderItem SaleOrderItem { get; set; } = null!;
}
