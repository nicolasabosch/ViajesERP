using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class PurchaseInvoice
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseInvoiceID { get; set; } = null!;

    /// <summary>
    /// Número Factura
    /// </summary>
    public int PurchaseInvoiceNumber { get; set; }

    /// <summary>
    /// Referencia
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? PurchaseInvoiceCode { get; set; }

    /// <summary>
    /// Fecha
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime PurchaseInvoiceDate { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string PaymentConditionID { get; set; } = null!;

    /// <summary>
    /// Estado
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentStatusID { get; set; } = null!;

    /// <summary>
    /// B.U.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    /// <summary>
    /// Proveedor
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string VendorID { get; set; } = null!;

    /// <summary>
    /// Moneda
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    /// <summary>
    /// Monto Total
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal TotalAmount { get; set; }

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

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("PurchaseInvoice")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [ForeignKey("CurrencyID")]
    [InverseProperty("PurchaseInvoice")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("DocumentStatusID")]
    [InverseProperty("PurchaseInvoice")]
    public virtual DocumentStatus DocumentStatus { get; set; } = null!;

    [ForeignKey("PaymentConditionID")]
    [InverseProperty("PurchaseInvoice")]
    public virtual PaymentCondition PaymentCondition { get; set; } = null!;

    [InverseProperty("PurchaseInvoice")]
    public virtual ICollection<PurchaseInvoicePurchaseReception> PurchaseInvoicePurchaseReception { get; } = new List<PurchaseInvoicePurchaseReception>();

    [ForeignKey("VendorID")]
    [InverseProperty("PurchaseInvoice")]
    public virtual Vendor Vendor { get; set; } = null!;
}
