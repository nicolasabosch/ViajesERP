using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vPriceListForVenta
{
    [StringLength(7)]
    [Unicode(false)]
    public string PriceListName { get; set; } = null!;

    [StringLength(200)]
    public string ProductTypeName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ProductFamilyID { get; set; } = null!;

    [StringLength(200)]
    public string ProductFamilyName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(200)]
    public string ProductName { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencyID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CurrencyName { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Price { get; set; }
}
