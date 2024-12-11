using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vStockAnalysis
{
    public bool Active { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(200)]
    public string ProductName { get; set; } = null!;

    [StringLength(200)]
    public string ProductFamilyName { get; set; } = null!;

    public int AvailableUnitsProducts { get; set; }

    public int AvailableUnitsFamily { get; set; }

    public int? ProductFamilyVariants { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? RequestedUnits { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? DeliveredUnits { get; set; }
}
