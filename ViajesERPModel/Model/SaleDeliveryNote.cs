using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Index("CustomerID", Name = "IX_SaleDeliveryNote_CustomerID")]
[Index("SaleDeliveryID", Name = "IX_SaleDeliveryNote_SaleDeliveryID")]
[Index("SubCustomerID", Name = "IX_SaleDeliveryNote_SubCustomerID")]
public partial class SaleDeliveryNote
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryNoteID { get; set; } = null!;

    public int SaleDeliveryNoteNumber { get; set; }

    [Column(TypeName = "date")]
    public DateTime? SaleDeliveryNoteDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryID { get; set; } = null!;

    /// <summary>
    /// Vendedor
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SaleRepresentativeID { get; set; }

    /// <summary>
    /// Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    /// <summary>
    /// Sub Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SubCustomerID { get; set; }

    /// <summary>
    /// Moneda
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    /// <summary>
    /// Condición de Pago
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? PaymentConditionID { get; set; }

    /// <summary>
    /// Canal
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ChannelID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal TotalCommissionAmount { get; set; }

    /// <summary>
    /// Estado
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryNoteStatusID { get; set; } = null!;

    /// <summary>
    /// Dock de carga
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? WarehouseID { get; set; }

    /// <summary>
    /// Urgencia
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? UrgencyID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? DeliveryStatusID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? DeliveryStatusDescription { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [Column(TypeName = "date")]
    public DateTime? RealDeliveryDate { get; set; }

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("SaleDeliveryNote")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [ForeignKey("ChannelID")]
    [InverseProperty("SaleDeliveryNote")]
    public virtual Channel Channel { get; set; } = null!;

    [ForeignKey("CurrencyID")]
    [InverseProperty("SaleDeliveryNote")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("CustomerID")]
    [InverseProperty("SaleDeliveryNote")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("PaymentConditionID")]
    [InverseProperty("SaleDeliveryNote")]
    public virtual PaymentCondition? PaymentCondition { get; set; }

    [ForeignKey("SaleDeliveryID")]
    [InverseProperty("SaleDeliveryNote")]
    public virtual SaleDelivery SaleDelivery { get; set; } = null!;

    [InverseProperty("SaleDeliveryNote")]
    public virtual ICollection<SaleDeliveryNoteItem> SaleDeliveryNoteItem { get; } = new List<SaleDeliveryNoteItem>();

    [ForeignKey("SaleDeliveryNoteStatusID")]
    [InverseProperty("SaleDeliveryNote")]
    public virtual SaleDeliveryNoteStatus SaleDeliveryNoteStatus { get; set; } = null!;

    [ForeignKey("UrgencyID")]
    [InverseProperty("SaleDeliveryNote")]
    public virtual Urgency? Urgency { get; set; }

    [ForeignKey("WarehouseID")]
    [InverseProperty("SaleDeliveryNote")]
    public virtual Warehouse? Warehouse { get; set; }
}
