using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class zRV
{
    public int ReceiptNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string ReceiptID { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal ReceiptAmount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal AmountInCurrency { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal Amount { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [Column(TypeName = "decimal(27, 15)")]
    public decimal? Parte { get; set; }
}
