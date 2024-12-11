using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class SaleDeliveryNoteHistoryItem
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryNoteHistoryItemID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryNoteHistoryID { get; set; } = null!;

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
    public decimal DeliveredQuantity { get; set; }

    /// <summary>
    /// Solicitado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal DeliveredUnits { get; set; }

    /// <summary>
    /// Precio
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// % Comisión
    /// </summary>
    [Column(TypeName = "decimal(5, 2)")]
    public decimal CommissionPercent { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("SaleDeliveryNoteHistoryID")]
    [InverseProperty("SaleDeliveryNoteHistoryItem")]
    public virtual SaleDeliveryNoteHistory SaleDeliveryNoteHistory { get; set; } = null!;
}
