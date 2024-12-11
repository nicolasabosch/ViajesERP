using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vBarCodeInventory
{
    [StringLength(36)]
    [Unicode(false)]
    public string? OrganizationUnitID { get; set; }

    [StringLength(200)]
    public string ProductFamilyName { get; set; } = null!;

    [StringLength(200)]
    public string ProductName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? Quantity { get; set; }

    public int? Units { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? HardCommittedQuantity { get; set; }

    public int? HardCommittedUnits { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? AvailableQuantity { get; set; }

    public int? AvailableUnits { get; set; }
}
