using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vSaleRetailItem
{
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRetailID { get; set; } = null!;

    [StringLength(200)]
    public string ProductFamilyName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(200)]
    public string ProductName { get; set; } = null!;

    [StringLength(200)]
    public string UnitOfMeasureName { get; set; } = null!;

    public int? Units { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? UnitPrice { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? Promedio { get; set; }

    [StringLength(200)]
    public string? PaisOrigen { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Estacionalidad { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Composicion { get; set; }
}
