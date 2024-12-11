using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vProductAvailableForPicking
{
    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? WarehouseID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string WarehouseName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? AvailableQuantity { get; set; }

    public int? AvailableUnits { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal AssignedQuantity { get; set; }

    public int? AssignedUnits { get; set; }
}
