using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class zInventory
{
    [StringLength(36)]
    [Unicode(false)]
    public string InventoryID { get; set; } = null!;

    public int InventoryNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? WarehouseID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? WarehousePositionID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? BatchName { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ProductionDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ExpirationDate { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal Available { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal HardCommitted { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal Quarantined { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal NotAvailable { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal SafetyStock { get; set; }

    public int AvailableUnits { get; set; }

    public int HardCommittedUnits { get; set; }

    public int QuarantinedUnits { get; set; }

    public int NotAvailableUnits { get; set; }

    public int SafetyStockUnits { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? TransitQuantity { get; set; }

    public int? TransitUnits { get; set; }
}
