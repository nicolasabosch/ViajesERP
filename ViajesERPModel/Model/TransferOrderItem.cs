using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class TransferOrderItem
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string TransferOrderItemID { get; set; } = null!;

    public int TransferOrderItemNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string TransferOrderID { get; set; } = null!;

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
    public decimal GrossQuantity { get; set; }

    /// <summary>
    /// Solicitado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal NetQuantity { get; set; }

    /// <summary>
    /// Solicitado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Units { get; set; }

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

    [ForeignKey("ProductID")]
    [InverseProperty("TransferOrderItem")]
    public virtual Product Product { get; set; } = null!;

    [ForeignKey("TransferOrderID")]
    [InverseProperty("TransferOrderItem")]
    public virtual TransferOrder TransferOrder { get; set; } = null!;

    [ForeignKey("UnitOfMeasureID")]
    [InverseProperty("TransferOrderItem")]
    public virtual UnitOfMeasure UnitOfMeasure { get; set; } = null!;
}
