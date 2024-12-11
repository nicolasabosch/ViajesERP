using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class SaleRetailValue
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRetailValueID { get; set; } = null!;

    public int SaleRetailValueNumber { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRetailID { get; set; } = null!;

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

    [StringLength(36)]
    [Unicode(false)]
    public string? CheckID { get; set; }

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
    public string? SaleRetailCreditID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BankID")]
    [InverseProperty("SaleRetailValue")]
    public virtual Bank? Bank { get; set; }

    [ForeignKey("CheckID")]
    [InverseProperty("SaleRetailValue")]
    public virtual Check? Check { get; set; }

    [ForeignKey("CheckStatusID")]
    [InverseProperty("SaleRetailValue")]
    public virtual CheckStatus? CheckStatus { get; set; }

    [ForeignKey("CurrencyID")]
    [InverseProperty("SaleRetailValue")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("EndorsableCompanyID")]
    [InverseProperty("SaleRetailValue")]
    public virtual EndorsableCompany? EndorsableCompany { get; set; }

    [ForeignKey("EndorsableCustomerID")]
    [InverseProperty("SaleRetailValue")]
    public virtual EndorsableCustomer? EndorsableCustomer { get; set; }

    [ForeignKey("SaleRetailID")]
    [InverseProperty("SaleRetailValue")]
    public virtual SaleRetail SaleRetail { get; set; } = null!;

    [ForeignKey("SaleRetailCreditID")]
    [InverseProperty("SaleRetailValue")]
    public virtual SaleRetailCredit? SaleRetailCredit { get; set; }

    [ForeignKey("ValueTypeID")]
    [InverseProperty("SaleRetailValue")]
    public virtual ValueType ValueType { get; set; } = null!;
}
