using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vVendorPayment
{
    public int VendorPaymentNumber { get; set; }

    [Column(TypeName = "date")]
    public DateTime VendorPaymentDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string OrganizationUnitName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string BusinessUnitName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string ChannelName { get; set; } = null!;

    [StringLength(202)]
    public string VendorName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? ExpenseTypeName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ExpenseSubTypeName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? PeriodID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string VendorPaymentClassID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CurrencyName { get; set; } = null!;

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? AmountInCurrency { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? Remarks { get; set; }
}
