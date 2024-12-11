using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class PaymentCondition
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PaymentConditionID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(200)]
    public string PaymentConditionName { get; set; } = null!;

    /// <summary>
    /// Días
    /// </summary>
    public short Days { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("PaymentCondition")]
    public virtual ICollection<AccountReceivable> AccountReceivable { get; } = new List<AccountReceivable>();

    [InverseProperty("PaymentCondition")]
    public virtual ICollection<Customer> Customer { get; } = new List<Customer>();

    [InverseProperty("PaymentCondition")]
    public virtual ICollection<PurchaseInvoice> PurchaseInvoice { get; } = new List<PurchaseInvoice>();

    [InverseProperty("PaymentCondition")]
    public virtual ICollection<SaleDeliveryNote> SaleDeliveryNote { get; } = new List<SaleDeliveryNote>();

    [InverseProperty("PaymentCondition")]
    public virtual ICollection<SaleOrder> SaleOrder { get; } = new List<SaleOrder>();

    [InverseProperty("PaymentCondition")]
    public virtual ICollection<TransferOrder> TransferOrder { get; } = new List<TransferOrder>();

    [InverseProperty("PaymentCondition")]
    public virtual ICollection<Vendor> Vendor { get; } = new List<Vendor>();
}
