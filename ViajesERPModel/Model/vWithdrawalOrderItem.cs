using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vWithdrawalOrderItem
{
    [StringLength(36)]
    [Unicode(false)]
    public string WithdrawalOrderID { get; set; } = null!;

    public int? Units { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? Meters { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? Kilos { get; set; }

    public int? Pieces { get; set; }
}
