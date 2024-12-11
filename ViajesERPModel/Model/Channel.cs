using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Channel
{
    /// <summary>
    /// Canal
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ChannelID { get; set; } = null!;

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string ChannelName { get; set; } = null!;

    /// <summary>
    /// Activo
    /// </summary>
    public bool Active { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("Channel")]
    public virtual ICollection<AccountPayable> AccountPayable { get; } = new List<AccountPayable>();

    [InverseProperty("Channel")]
    public virtual ICollection<AccountReceivable> AccountReceivable { get; } = new List<AccountReceivable>();

    [InverseProperty("Channel")]
    public virtual ICollection<BatchPayment> BatchPayment { get; } = new List<BatchPayment>();

    [InverseProperty("Channel")]
    public virtual ICollection<Check> Check { get; } = new List<Check>();

    [InverseProperty("Channel")]
    public virtual ICollection<CommissionPayable> CommissionPayable { get; } = new List<CommissionPayable>();

    [InverseProperty("Channel")]
    public virtual ICollection<CreditNote> CreditNote { get; } = new List<CreditNote>();

    [InverseProperty("Channel")]
    public virtual ICollection<Customer> Customer { get; } = new List<Customer>();

    [InverseProperty("Channel")]
    public virtual ICollection<DebitNote> DebitNote { get; } = new List<DebitNote>();

    [InverseProperty("Channel")]
    public virtual ICollection<Document> Document { get; } = new List<Document>();

    [InverseProperty("Channel")]
    public virtual ICollection<Journal> Journal { get; } = new List<Journal>();

    [InverseProperty("Channel")]
    public virtual ICollection<Receipt> Receipt { get; } = new List<Receipt>();

    [InverseProperty("Channel")]
    public virtual ICollection<SaleDeliveryNote> SaleDeliveryNote { get; } = new List<SaleDeliveryNote>();

    [InverseProperty("Channel")]
    public virtual ICollection<SaleDeliveryNoteHistory> SaleDeliveryNoteHistory { get; } = new List<SaleDeliveryNoteHistory>();

    [InverseProperty("Channel")]
    public virtual ICollection<SaleOrder> SaleOrder { get; } = new List<SaleOrder>();

    [InverseProperty("Channel")]
    public virtual ICollection<VendorPayment> VendorPayment { get; } = new List<VendorPayment>();
}
