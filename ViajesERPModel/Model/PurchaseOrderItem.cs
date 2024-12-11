using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class PurchaseOrderItem
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseOrderItemID { get; set; } = null!;

    public int PurchaseOrderItemNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseOrderID { get; set; } = null!;

    /// <summary>
    /// Producto
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    /// <summary>
    /// Medida
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string UnitOfMeasureID { get; set; } = null!;

    /// <summary>
    /// Solicitado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal RequestedQuantity { get; set; }

    /// <summary>
    /// Solicitado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? RequestedUnits { get; set; }

    /// <summary>
    /// Precio FOB Unitario
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal UnitFOBPrice { get; set; }

    /// <summary>
    /// Comentarios
    /// </summary>
    [Unicode(false)]
    public string? Remarks { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("ProductID")]
    [InverseProperty("PurchaseOrderItem")]
    public virtual Product Product { get; set; } = null!;

    [InverseProperty("PurchaseOrderItem")]
    public virtual ICollection<PurchaseDeliveryItem> PurchaseDeliveryItem { get; } = new List<PurchaseDeliveryItem>();

    [ForeignKey("PurchaseOrderID")]
    [InverseProperty("PurchaseOrderItem")]
    public virtual PurchaseOrder PurchaseOrder { get; set; } = null!;

    [ForeignKey("UnitOfMeasureID")]
    [InverseProperty("PurchaseOrderItem")]
    public virtual UnitOfMeasure UnitOfMeasure { get; set; } = null!;
}
