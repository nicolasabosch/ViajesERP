using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vSaleRetail
{
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRetailID { get; set; } = null!;

    public int SaleRetailNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? OrganizationUnitContactID { get; set; }

    [Column(TypeName = "date")]
    public DateTime SaleRetailDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? FinancingAmount { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleRetailTypeCode { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ContactDescription { get; set; }

    public int? ItemsQuantity { get; set; }

    [Column(TypeName = "date")]
    public DateTime? RealDeliveryDate { get; set; }
}
