using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class CreditNoteItem
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CreditNoteItemID { get; set; } = null!;

    public int CreditNoteItemNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CreditNoteID { get; set; } = null!;

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
    public decimal Quantity { get; set; }

    /// <summary>
    /// Solicitado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Units { get; set; }

    /// <summary>
    /// Precio
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Precio Sub Cliente
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal UnitOtherPrice { get; set; }

    /// <summary>
    /// % Comisión
    /// </summary>
    [Column(TypeName = "decimal(5, 2)")]
    public decimal CommissionPercent { get; set; }

    /// <summary>
    /// Ubicación
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string WarehousePositionID { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("CreditNoteID")]
    [InverseProperty("CreditNoteItem")]
    public virtual CreditNote CreditNote { get; set; } = null!;

    [ForeignKey("ProductID")]
    [InverseProperty("CreditNoteItem")]
    public virtual Product Product { get; set; } = null!;

    [ForeignKey("UnitOfMeasureID")]
    [InverseProperty("CreditNoteItem")]
    public virtual UnitOfMeasure UnitOfMeasure { get; set; } = null!;

    [ForeignKey("WarehousePositionID")]
    [InverseProperty("CreditNoteItem")]
    public virtual WarehousePosition WarehousePosition { get; set; } = null!;
}
