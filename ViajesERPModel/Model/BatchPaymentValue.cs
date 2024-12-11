using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class BatchPaymentValue
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string BatchPaymentValueID { get; set; } = null!;

    public int BatchPaymentValueNumber { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string BatchPaymentID { get; set; } = null!;

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SourceReceiptID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string ValueTypeID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal AmountInCurrency { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CurrencyRateAmount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal Amount { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? BankID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? BankBranchCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ValueText { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ValueDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ValueIssueDate { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ValueOwnerName { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ValueOwnerTax { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? SubCustomerID { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? CheckStatusID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CheckStatusDescription { get; set; }

    /// <summary>
    /// EndorsableCustomerID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? EndorsableCustomerID { get; set; }

    /// <summary>
    /// EndorsableCompanyID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? EndorsableCompanyID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? MarkCode { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? VendorID { get; set; }

    [Column(TypeName = "date")]
    public DateTime? VendorPaymentDate { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BankID")]
    [InverseProperty("BatchPaymentValue")]
    public virtual Bank? Bank { get; set; }

    [ForeignKey("BatchPaymentID")]
    [InverseProperty("BatchPaymentValue")]
    public virtual BatchPayment BatchPayment { get; set; } = null!;

    [InverseProperty("BatchPaymentValue")]
    public virtual ICollection<Check> Check { get; } = new List<Check>();

    [ForeignKey("CheckStatusID")]
    [InverseProperty("BatchPaymentValue")]
    public virtual CheckStatus? CheckStatus { get; set; }

    [ForeignKey("CurrencyID")]
    [InverseProperty("BatchPaymentValue")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("EndorsableCompanyID")]
    [InverseProperty("BatchPaymentValue")]
    public virtual EndorsableCompany? EndorsableCompany { get; set; }

    [ForeignKey("EndorsableCustomerID")]
    [InverseProperty("BatchPaymentValue")]
    public virtual EndorsableCustomer? EndorsableCustomer { get; set; }

    [InverseProperty("BatchPaymentValue")]
    public virtual ICollection<ReceiptValue> ReceiptValue { get; } = new List<ReceiptValue>();

    [ForeignKey("ValueTypeID")]
    [InverseProperty("BatchPaymentValue")]
    public virtual ValueType ValueType { get; set; } = null!;
}
