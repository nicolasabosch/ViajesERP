using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vProductSoftCommitted
{
    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? RequestedQuantity { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? RequestedUnits { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? DeliveredQuantity { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? DeliveredUnits { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? OpenQuantity { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? OpenUnits { get; set; }
}
