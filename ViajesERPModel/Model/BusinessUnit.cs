using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class BusinessUnit
{
    /// <summary>
    /// B.U.
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string BusinessUnitName { get; set; } = null!;

    /// <summary>
    /// Tipo
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitTypeID { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<AccountPayable> AccountPayable { get; } = new List<AccountPayable>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<AccountReceivable> AccountReceivable { get; } = new List<AccountReceivable>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<BatchPayment> BatchPayment { get; } = new List<BatchPayment>();

    [ForeignKey("BusinessUnitTypeID")]
    [InverseProperty("BusinessUnit")]
    public virtual BusinessUnitType BusinessUnitType { get; set; } = null!;

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<CommissionPayable> CommissionPayable { get; } = new List<CommissionPayable>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<CountOrder> CountOrder { get; } = new List<CountOrder>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<CreditNote> CreditNote { get; } = new List<CreditNote>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<CustomerBusinessUnit> CustomerBusinessUnit { get; } = new List<CustomerBusinessUnit>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<DebitNote> DebitNote { get; } = new List<DebitNote>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<Document> Document { get; } = new List<Document>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<ExpenseType> ExpenseType { get; } = new List<ExpenseType>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<Inventory> Inventory { get; } = new List<Inventory>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<Journal> Journal { get; } = new List<Journal>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<ProductBusinessUnit> ProductBusinessUnit { get; } = new List<ProductBusinessUnit>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<PurchaseInvoice> PurchaseInvoice { get; } = new List<PurchaseInvoice>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<PurchaseOrder> PurchaseOrder { get; } = new List<PurchaseOrder>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<Receipt> Receipt { get; } = new List<Receipt>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<SaleDeliveryNote> SaleDeliveryNote { get; } = new List<SaleDeliveryNote>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<SaleRepresentativePayment> SaleRepresentativePayment { get; } = new List<SaleRepresentativePayment>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<TransferOrder> TransferOrder { get; } = new List<TransferOrder>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<VendorPayment> VendorPayment { get; } = new List<VendorPayment>();

    [InverseProperty("BusinessUnit")]
    public virtual ICollection<WithdrawalOrder> WithdrawalOrder { get; } = new List<WithdrawalOrder>();
}
