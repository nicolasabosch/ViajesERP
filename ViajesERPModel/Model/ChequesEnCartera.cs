using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class ChequesEnCartera
{
    [StringLength(36)]
    [Unicode(false)]
    public string JournalID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string DocumentTypeName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string BusinessUnitName { get; set; } = null!;

    public int? DocumentNumber { get; set; }

    [Column(TypeName = "date")]
    public DateTime DocumentDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string OrganizationUnitName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CurrencyName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ValueTypeName { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal AmountInCurrency { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CurrencyRateAmount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal Amount { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BankName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ValueText { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ValueDate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ValueOwnerTax { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ValueOwnerName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? PeriodID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ValueStatusName { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CustomerName { get; set; }

    public int? CustomerNumber { get; set; }
}
