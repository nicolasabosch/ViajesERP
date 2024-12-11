using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class xCobranzaPorVendorPeriodo
{
    [StringLength(500)]
    [Unicode(false)]
    public string? Period { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CobranzaUSDOficial { get; set; }

    [StringLength(201)]
    public string Vendedor { get; set; } = null!;
}
