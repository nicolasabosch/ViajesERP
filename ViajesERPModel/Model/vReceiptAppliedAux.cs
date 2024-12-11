using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vReceiptAppliedAux
{
    [StringLength(36)]
    [Unicode(false)]
    public string CustomeriD { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ReceiptID { get; set; } = null!;

    public int ReceiptNumber { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal ReceiptAmount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? AdvancePaymentAmountInCurrency { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal AppliedAmountInCurrency { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal AppliedAmount { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CurrencyRateAmount { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string NC { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string ND { get; set; } = null!;
}
