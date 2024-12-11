using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vProductWareHouseInventoryAndSoftCommitted
{
    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? WarehouseID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? WarehouseName { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string BusinessUnitName { get; set; } = null!;

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? AvailableQuantity { get; set; }

    public int? AvailableUnits { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? HardCommittedQuantity { get; set; }

    public int? HardCommittedUnits { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? QuarentinedQuantity { get; set; }

    public int? QuarentinedUnits { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? NotAvailableQuantity { get; set; }

    public int? NotAvailableUnits { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? RequestedQuantity { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? RequestedUnits { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? DeliveredQuantity { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? DeliveredUnits { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? AvailableQuantitySum { get; set; }

    public int? AvailableUnitsSum { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? WeightedQuantity { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? WeightedUnits { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? TransitQuantity { get; set; }

    public int? TransitUnits { get; set; }
}
