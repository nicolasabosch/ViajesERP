using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class DocumentStatus
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentStatusID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string DocumentStatusName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("DocumentStatus")]
    public virtual ICollection<CreditNote> CreditNote { get; } = new List<CreditNote>();

    [InverseProperty("DocumentStatus")]
    public virtual ICollection<DebitNote> DebitNote { get; } = new List<DebitNote>();

    [InverseProperty("DocumentStatus")]
    public virtual ICollection<Document> Document { get; } = new List<Document>();

    [InverseProperty("DocumentStatus")]
    public virtual ICollection<PurchaseInvoice> PurchaseInvoice { get; } = new List<PurchaseInvoice>();

    [InverseProperty("DocumentStatus")]
    public virtual ICollection<Receipt> Receipt { get; } = new List<Receipt>();

    [InverseProperty("DocumentStatus")]
    public virtual ICollection<SaleRepresentativePayment> SaleRepresentativePayment { get; } = new List<SaleRepresentativePayment>();

    [InverseProperty("DocumentStatus")]
    public virtual ICollection<VendorPayment> VendorPayment { get; } = new List<VendorPayment>();
}
