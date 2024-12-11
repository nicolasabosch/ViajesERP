using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class WithdrawalOrderItem
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string WithdrawalOrderItemID { get; set; } = null!;

    public int WithdrawalOrderItemNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string WithdrawalOrderID { get; set; } = null!;

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
    public string? CurrencyID { get; set; }

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

    [ForeignKey("CurrencyID")]
    [InverseProperty("WithdrawalOrderItem")]
    public virtual Currency? Currency { get; set; }

    [ForeignKey("ProductID")]
    [InverseProperty("WithdrawalOrderItem")]
    public virtual Product Product { get; set; } = null!;

    [ForeignKey("UnitOfMeasureID")]
    [InverseProperty("WithdrawalOrderItem")]
    public virtual UnitOfMeasure UnitOfMeasure { get; set; } = null!;

    [ForeignKey("WithdrawalOrderID")]
    [InverseProperty("WithdrawalOrderItem")]
    public virtual WithdrawalOrder WithdrawalOrder { get; set; } = null!;
}
