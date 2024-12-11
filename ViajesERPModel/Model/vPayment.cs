using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vPayment
{
    public int DocumentNumber { get; set; }

    [Column(TypeName = "date")]
    public DateTime DocumentDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? DocumentType { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string OrganizationUnitName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string DocumentCurrency { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal DocumentAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DocumentCurrencyRate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ValueTypeName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ValueCurrency { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal AmountInCurrency { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal ValueAmount { get; set; }
}
