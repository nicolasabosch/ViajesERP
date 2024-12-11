using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class SaleDeliveryNoteItem
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryNoteItemID { get; set; } = null!;

    public int SaleDeliveryNoteItemNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryNoteID { get; set; } = null!;

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
    /// Precio
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// % Comisión
    /// </summary>
    [Column(TypeName = "decimal(5, 2)")]
    public decimal CommissionPercent { get; set; }

    /// <summary>
    /// Despacho de Aduana
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? CustomDeliveryCode { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("ProductID")]
    [InverseProperty("SaleDeliveryNoteItem")]
    public virtual Product Product { get; set; } = null!;

    [ForeignKey("SaleDeliveryNoteID")]
    [InverseProperty("SaleDeliveryNoteItem")]
    public virtual SaleDeliveryNote SaleDeliveryNote { get; set; } = null!;

    [ForeignKey("UnitOfMeasureID")]
    [InverseProperty("SaleDeliveryNoteItem")]
    public virtual UnitOfMeasure UnitOfMeasure { get; set; } = null!;
}
