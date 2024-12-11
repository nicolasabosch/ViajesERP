using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("PurchaseInvoiceID", "PurchaseReceptionID")]
public partial class PurchaseInvoicePurchaseReception
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseInvoiceID { get; set; } = null!;

    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseReceptionID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal AppliedAmount { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("PurchaseInvoiceID")]
    [InverseProperty("PurchaseInvoicePurchaseReception")]
    public virtual PurchaseInvoice PurchaseInvoice { get; set; } = null!;

    [ForeignKey("PurchaseReceptionID")]
    [InverseProperty("PurchaseInvoicePurchaseReception")]
    public virtual PurchaseReception PurchaseReception { get; set; } = null!;
}
