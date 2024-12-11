using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class xVentasCobranzaPorVendorFecha
{
    [StringLength(10)]
    [Unicode(false)]
    public string? Fecha { get; set; }

    [StringLength(201)]
    public string? Vendedor { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Canal { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Concepto { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal VentasUSDOficial { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CobranzaUSDOficial { get; set; }
}
