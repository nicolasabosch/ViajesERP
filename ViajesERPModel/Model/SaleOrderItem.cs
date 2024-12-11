using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Index("ProductID", Name = "IX_SaleOrderItem_ProductID")]
[Index("SaleOrderID", Name = "IX_SaleOrderItem_SaleOrderID")]
public partial class SaleOrderItem
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleOrderItemID { get; set; } = null!;

    public int SaleOrderItemNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string SaleOrderID { get; set; } = null!;

    /// <summary>
    /// Producto
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? BusinessUnitID { get; set; }

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
    /// Precio Lista
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal? UnitListPrice { get; set; }

    /// <summary>
    /// Precio
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal? UnitPrice { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? OtherPriceCurrencyID { get; set; }

    /// <summary>
    /// Precio Subcliente
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal? UnitOtherPrice { get; set; }

    /// <summary>
    /// % Comisión
    /// </summary>
    [Column(TypeName = "decimal(5, 2)")]
    public decimal? CommissionPercent { get; set; }

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

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? UnitPriceCoefficient { get; set; }

    [InverseProperty("SaleOrderItem")]
    public virtual ICollection<PickingOrderItem> PickingOrderItem { get; } = new List<PickingOrderItem>();

    [InverseProperty("SaleOrderItem")]
    public virtual ICollection<SaleDeliveryItem> SaleDeliveryItem { get; } = new List<SaleDeliveryItem>();

    [ForeignKey("SaleOrderID")]
    [InverseProperty("SaleOrderItem")]
    public virtual SaleOrder SaleOrder { get; set; } = null!;
}
