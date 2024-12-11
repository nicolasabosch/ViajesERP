using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Currency
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CurrencyName { get; set; } = null!;

    public short DisplayOrder { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CurrencyRateAmount { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("Currency")]
    public virtual ICollection<AccountPayable> AccountPayable { get; } = new List<AccountPayable>();

    [InverseProperty("Currency")]
    public virtual ICollection<AccountReceivable> AccountReceivable { get; } = new List<AccountReceivable>();

    [InverseProperty("Currency")]
    public virtual ICollection<BatchPaymentValue> BatchPaymentValue { get; } = new List<BatchPaymentValue>();

    [InverseProperty("Currency")]
    public virtual ICollection<CommissionPayable> CommissionPayable { get; } = new List<CommissionPayable>();

    [InverseProperty("Currency")]
    public virtual ICollection<CreditNote> CreditNote { get; } = new List<CreditNote>();

    [InverseProperty("Currency")]
    public virtual ICollection<CurrencyRate> CurrencyRate { get; } = new List<CurrencyRate>();

    [InverseProperty("Currency")]
    public virtual ICollection<Customer> Customer { get; } = new List<Customer>();

    [InverseProperty("Currency")]
    public virtual ICollection<DebitNote> DebitNote { get; } = new List<DebitNote>();

    [InverseProperty("Currency")]
    public virtual ICollection<Document> Document { get; } = new List<Document>();

    [InverseProperty("Currency")]
    public virtual ICollection<Journal> Journal { get; } = new List<Journal>();

    [InverseProperty("Currency")]
    public virtual ICollection<PriceListProduct> PriceListProduct { get; } = new List<PriceListProduct>();

    [InverseProperty("Currency")]
    public virtual ICollection<PriceListProductFamily> PriceListProductFamily { get; } = new List<PriceListProductFamily>();

    [InverseProperty("Currency")]
    public virtual ICollection<PurchaseInvoice> PurchaseInvoice { get; } = new List<PurchaseInvoice>();

    [InverseProperty("Currency")]
    public virtual ICollection<PurchaseOrder> PurchaseOrder { get; } = new List<PurchaseOrder>();

    [InverseProperty("Currency")]
    public virtual ICollection<ReceiptValue> ReceiptValue { get; } = new List<ReceiptValue>();

    [InverseProperty("Currency")]
    public virtual ICollection<SaleDeliveryNote> SaleDeliveryNote { get; } = new List<SaleDeliveryNote>();

    [InverseProperty("Currency")]
    public virtual ICollection<SaleOrder> SaleOrder { get; } = new List<SaleOrder>();

    [InverseProperty("Currency")]
    public virtual ICollection<SaleRepresentativePaymentValue> SaleRepresentativePaymentValue { get; } = new List<SaleRepresentativePaymentValue>();

    [InverseProperty("Currency")]
    public virtual ICollection<SaleRetail> SaleRetail { get; } = new List<SaleRetail>();

    [InverseProperty("Currency")]
    public virtual ICollection<SaleRetailCredit> SaleRetailCredit { get; } = new List<SaleRetailCredit>();

    [InverseProperty("Currency")]
    public virtual ICollection<SaleRetailValue> SaleRetailValue { get; } = new List<SaleRetailValue>();

    [InverseProperty("Currency")]
    public virtual ICollection<TransferOrder> TransferOrder { get; } = new List<TransferOrder>();

    [InverseProperty("Currency")]
    public virtual ICollection<VendorPaymentValue> VendorPaymentValue { get; } = new List<VendorPaymentValue>();

    [InverseProperty("Currency")]
    public virtual ICollection<WithdrawalOrderItem> WithdrawalOrderItem { get; } = new List<WithdrawalOrderItem>();
}
