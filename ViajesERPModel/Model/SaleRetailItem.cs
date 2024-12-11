using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class SaleRetailItem
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRetailItemID { get; set; } = null!;

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRetailID { get; set; } = null!;

    /// <summary>
    /// Producto
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    /// <summary>
    /// Cantidad
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Quantity { get; set; }

    /// <summary>
    /// Etiqueta
    /// </summary>
    public int? InventoryBarCodeID { get; set; }

    /// <summary>
    /// Precio
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Comentarios
    /// </summary>
    [StringLength(2000)]
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

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? UnitListPrice { get; set; }

    [ForeignKey("InventoryBarCodeID")]
    [InverseProperty("SaleRetailItem")]
    public virtual InventoryBarCode? InventoryBarCode { get; set; }

    [ForeignKey("ProductID")]
    [InverseProperty("SaleRetailItem")]
    public virtual Product Product { get; set; } = null!;

    [ForeignKey("SaleRetailID")]
    [InverseProperty("SaleRetailItem")]
    public virtual SaleRetail SaleRetail { get; set; } = null!;
}
