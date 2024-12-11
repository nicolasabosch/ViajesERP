using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Receipt
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ReceiptID { get; set; } = null!;

    /// <summary>
    /// Receipt Number
    /// </summary>
    public int ReceiptNumber { get; set; }

    /// <summary>
    /// Referencia
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? ReceiptCode { get; set; }

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
    /// Date
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime ReceiptDate { get; set; }

    /// <summary>
    /// Remarks
    /// </summary>
    [StringLength(4000)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    /// <summary>
    /// Customer Id
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    /// <summary>
    /// Sub Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SubCustomerID { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal ReceiptAmount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal AdvancedPaymentAmount { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentStatusID { get; set; } = null!;

    [Unicode(false)]
    public string? JsonData { get; set; }

    /// <summary>
    /// Tipo de Recibo
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ReceiptClassID { get; set; }

    /// <summary>
    /// Concepto
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ExpenseTypeID { get; set; }

    /// <summary>
    /// Sub Concepto
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ExpenseSubTypeID { get; set; }

    /// <summary>
    /// Período
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? PeriodID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ReceiptStatusDescription { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? AdvancePaymentCurrencyID { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? AdvancePaymentAmountInCurrency { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? AdvancePaymentCurrencyRateAmount { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? ReceiptControlStatusID { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ReceiptControlDate { get; set; }

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("Receipt")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [ForeignKey("ChannelID")]
    [InverseProperty("Receipt")]
    public virtual Channel Channel { get; set; } = null!;

    [InverseProperty("Receipt")]
    public virtual ICollection<CreditNote> CreditNote { get; } = new List<CreditNote>();

    [InverseProperty("Receipt")]
    public virtual ICollection<DebitNote> DebitNote { get; } = new List<DebitNote>();

    [ForeignKey("DocumentStatusID")]
    [InverseProperty("Receipt")]
    public virtual DocumentStatus DocumentStatus { get; set; } = null!;

    [ForeignKey("OrganizationUnitID")]
    [InverseProperty("Receipt")]
    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;

    [InverseProperty("Receipt")]
    public virtual ICollection<ReceiptAccountReceivable> ReceiptAccountReceivable { get; } = new List<ReceiptAccountReceivable>();

    [InverseProperty("Receipt")]
    public virtual ICollection<ReceiptFile> ReceiptFile { get; } = new List<ReceiptFile>();

    [InverseProperty("Receipt")]
    public virtual ICollection<ReceiptValue> ReceiptValue { get; } = new List<ReceiptValue>();
}
