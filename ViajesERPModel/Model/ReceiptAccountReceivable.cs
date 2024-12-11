using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ReceiptAccountReceivable
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ReceiptAccountReceivableID { get; set; } = null!;

    public int ReceiptAccountReceivableNumber { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ReceiptID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string AccountReceivableID { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal AppliedAmount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal AppliedAmountInCurrency { get; set; }

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

    [ForeignKey("AccountReceivableID")]
    [InverseProperty("ReceiptAccountReceivable")]
    public virtual AccountReceivable AccountReceivable { get; set; } = null!;

    [ForeignKey("ReceiptID")]
    [InverseProperty("ReceiptAccountReceivable")]
    public virtual Receipt Receipt { get; set; } = null!;
}
