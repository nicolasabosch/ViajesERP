using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Index("SaleDeliveryID", Name = "IX_SaleDeliveryItem")]
[Index("ProductID", Name = "IX_SaleDeliveryItem_ProductID")]
[Index("SaleOrderItemID", Name = "IX_SaleDeliveryItem_SaleOrderItemID")]
public partial class SaleDeliveryItem
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryItemID { get; set; } = null!;

    public int SaleDeliveryItemNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string SaleOrderItemID { get; set; } = null!;

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
    public decimal DeliveredQuantity { get; set; }

    /// <summary>
    /// Solicitado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal DeliveredUnits { get; set; }

    /// <summary>
    /// Posición Origen Producto
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? InventoryID { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string? LabelCode { get; set; }

    public int? InventoryBarCodeID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? PickingOrderItemID { get; set; }

    [ForeignKey("InventoryID")]
    [InverseProperty("SaleDeliveryItem")]
    public virtual Inventory? Inventory { get; set; }

    [ForeignKey("SaleDeliveryID")]
    [InverseProperty("SaleDeliveryItem")]
    public virtual SaleDelivery SaleDelivery { get; set; } = null!;

    [ForeignKey("SaleOrderItemID")]
    [InverseProperty("SaleDeliveryItem")]
    public virtual SaleOrderItem SaleOrderItem { get; set; } = null!;
}
