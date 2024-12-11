using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class xCobranzaPorVendorFecha
{
    [Column(TypeName = "date")]
    public DateTime Fecha { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CobranzaUSDOficial { get; set; }

    [StringLength(201)]
    public string Vendedor { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? Canal { get; set; }
}
