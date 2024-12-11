using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vReceiptApplied
{
    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ReceiptID { get; set; } = null!;

    public int ReceiptNumber { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal AppliedAmount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal AppliedAmountInCurrency { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CurrencyRateAmount { get; set; }
}
