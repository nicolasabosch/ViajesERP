using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class VendorPaymentValue
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string VendorPaymentValueID { get; set; } = null!;

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string VendorPaymentID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ValueTypeID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
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
    public string? CheckID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BankID")]
    [InverseProperty("VendorPaymentValue")]
    public virtual Bank? Bank { get; set; }

    [ForeignKey("CurrencyID")]
    [InverseProperty("VendorPaymentValue")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("ValueTypeID")]
    [InverseProperty("VendorPaymentValue")]
    public virtual ValueType ValueType { get; set; } = null!;

    [ForeignKey("VendorPaymentID")]
    [InverseProperty("VendorPaymentValue")]
    public virtual VendorPayment VendorPayment { get; set; } = null!;
}
