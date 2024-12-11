using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vDetallePedidosFulltex
{
    [StringLength(200)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    public int CustomerNumber { get; set; }

    public int SaleOrderNumber { get; set; }

    [Column(TypeName = "date")]
    public DateTime RequestedDate { get; set; }

    [StringLength(201)]
    public string Vendedor { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string SaleOrderStatusID { get; set; } = null!;

    [StringLength(200)]
    public string ProductFamilyName { get; set; } = null!;

    [StringLength(200)]
    public string ProductName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string UnitOfMeasureID { get; set; } = null!;

    [StringLength(8000)]
    [Unicode(false)]
    public string? RequestedQuantity { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? RequestedUnits { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? UnitPrice { get; set; }
}
