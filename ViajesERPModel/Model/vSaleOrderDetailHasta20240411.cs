using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vSaleOrderDetailHasta20240411
{
    public int SaleOrderNumber { get; set; }

    [Column(TypeName = "date")]
    public DateTime? SaleOrderDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string BusinessUnitName { get; set; } = null!;

    [StringLength(201)]
    public string SaleRepresentativeName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal RequestedQuantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? RequestedUnits { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? UnitPrice { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? CurrencyID { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalPriceInCurrency { get; set; }

    [StringLength(200)]
    public string ProductName { get; set; } = null!;

    [StringLength(200)]
    public string ProductFamilyName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? SaleChannelName { get; set; }
}
