using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Check
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CheckID { get; set; } = null!;

    /// <summary>
    /// U.O.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitID { get; set; } = null!;

    /// <summary>
    /// B.U.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    /// <summary>
    /// B.U.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SourceBusinessUnitID { get; set; } = null!;

    /// <summary>
    /// Canal
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ChannelID { get; set; } = null!;

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ReceiptID { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SourceReceiptID { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? VendorPaymentID { get; set; }

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

    [StringLength(36)]
    [Unicode(false)]
    public string? BatchPaymentValueID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BatchPaymentValueID")]
    [InverseProperty("Check")]
    public virtual BatchPaymentValue? BatchPaymentValue { get; set; }

    [ForeignKey("ChannelID")]
    [InverseProperty("Check")]
    public virtual Channel Channel { get; set; } = null!;

    [InverseProperty("Check")]
    public virtual ICollection<DebitNoteCheck> DebitNoteCheck { get; } = new List<DebitNoteCheck>();

    [InverseProperty("Check")]
    public virtual ICollection<ReceiptValue> ReceiptValue { get; } = new List<ReceiptValue>();

    [InverseProperty("Check")]
    public virtual ICollection<SaleRetailValue> SaleRetailValue { get; } = new List<SaleRetailValue>();
}
