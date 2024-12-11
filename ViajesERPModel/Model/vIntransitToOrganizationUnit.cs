using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vIntransitToOrganizationUnit
{
    [StringLength(36)]
    [Unicode(false)]
    public string WarehouseID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? PreparedQuantity { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? PreparedUnits { get; set; }
}
