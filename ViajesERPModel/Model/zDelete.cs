using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class zDelete
{
    [StringLength(11)]
    [Unicode(false)]
    public string? ReceiptCode { get; set; }

    [Column(TypeName = "date")]
    public DateTime ReceiptDate { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string ReceiptClassName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string BusinessUnitName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string OrganizationUnitName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string ChannelName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    [StringLength(201)]
    public string SaleRepresentativeName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? SaleChannelName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ValueTypeName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ValueTypeGroupName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CurrencyName { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal AmountInCurrency { get; set; }

    [Column(TypeName = "date")]
    public DateTime ValueDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CheckStatusID { get; set; } = null!;
}
