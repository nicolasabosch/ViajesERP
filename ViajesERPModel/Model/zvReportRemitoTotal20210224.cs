using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class zvReportRemitoTotal20210224
{
    public int NroPedido { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FechaRemito { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FechaPedido { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? UN { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Concepto { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? Deposito { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Cliente { get; set; }

    [StringLength(201)]
    public string? Vendedor { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? CantidadPedido { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? CantidadRemito { get; set; }

    public int? BultosPedido { get; set; }

    public int? BultosRemito { get; set; }

    [StringLength(200)]
    public string? Unidad { get; set; }

    [StringLength(200)]
    public string? Familia { get; set; }

    [StringLength(200)]
    public string? Producto { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Moneda { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? UnitarioUSDOF { get; set; }
}
