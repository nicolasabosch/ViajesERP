using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vReceiptValue
{
    [StringLength(36)]
    [Unicode(false)]
    public string ReceiptID { get; set; } = null!;

    public int ReceiptNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal AdvancedPaymentAmount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal ReceiptAmount { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string ValueTypeID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CurrencyRateAmount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? AmountInCurrency { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? ReceiptValueID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? CheckID { get; set; }
}
