using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class SaleRepresentativePaymentValue
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRepresentativePaymentValueID { get; set; } = null!;

    public int SaleRepresentativePaymentNumber { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRepresentativePaymentID { get; set; } = null!;

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
    public string? JournalID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BankID")]
    [InverseProperty("SaleRepresentativePaymentValue")]
    public virtual Bank? Bank { get; set; }

    [ForeignKey("CurrencyID")]
    [InverseProperty("SaleRepresentativePaymentValue")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("JournalID")]
    [InverseProperty("SaleRepresentativePaymentValue")]
    public virtual Journal? Journal { get; set; }

    [ForeignKey("SaleRepresentativePaymentID")]
    [InverseProperty("SaleRepresentativePaymentValue")]
    public virtual SaleRepresentativePayment SaleRepresentativePayment { get; set; } = null!;

    [ForeignKey("ValueTypeID")]
    [InverseProperty("SaleRepresentativePaymentValue")]
    public virtual ValueType ValueType { get; set; } = null!;
}
