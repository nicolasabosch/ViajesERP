using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vReportReceiptAppliedHasta20240823
{
    public int ReceiptNumber { get; set; }

    [Column(TypeName = "date")]
    public DateTime ReceiptDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitID { get; set; } = null!;

    public int CustomerNumber { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    [StringLength(201)]
    public string? SalesRepresentativeName { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal ReceiptAmount { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string ValueTypeID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ValueCurrencyID { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? ValueAmountInCurrency { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? AppliedAmount { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? AppliedAmountInCurrency { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string AppliedCurrencyID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CurrencyRateAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ValueCurrencyRateAmount { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BankName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? BankBranchCode { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? ValueAmount { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ValueDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ValueCode { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? ReceiptClassID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CheckStatusName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EndorsableCompanyName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EndorsableCustomerName { get; set; }
}
