using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class InventoryMovement
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string InventoryMovementID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string InventoryMovementName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string WarehousePositionID { get; set; } = null!;

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? DocumentName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? DocumentID { get; set; }

    public int? DocumentNumber { get; set; }

    /// <summary>
    /// Picking
    /// </summary>
    public int? HardCommittedUnits { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Available { get; set; }

    /// <summary>
    /// Picking
    /// </summary>
    [Column(TypeName = "decimal(18, 6)")]
    public decimal? HardCommitted { get; set; }

    public int? AvailableUnits { get; set; }

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
