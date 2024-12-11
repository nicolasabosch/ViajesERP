using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class xStockActualValorizado
{
    [StringLength(200)]
    public string Tipo { get; set; } = null!;

    [StringLength(200)]
    public string Familia { get; set; } = null!;

    [StringLength(200)]
    public string Marca { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Codigo { get; set; } = null!;

    [StringLength(200)]
    public string Descripcion { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? Deposito { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    [StringLength(200)]
    public string UnMedida { get; set; } = null!;

    [Column("Bultos Estantería")]
    public int? Bultos_Estantería { get; set; }

    [Column("mts/kg Estantería", TypeName = "decimal(38, 6)")]
    public decimal? mts_kg_Estantería { get; set; }

    [Column("Bultos Preparados")]
    public int? Bultos_Preparados { get; set; }

    [Column("mts/kg Preparados", TypeName = "decimal(38, 6)")]
    public decimal? mts_kg_Preparados { get; set; }

    [Column("Bultos Pedidos Ponderado", TypeName = "decimal(38, 6)")]
    public decimal? Bultos_Pedidos_Ponderado { get; set; }

    [Column("mts/kg Pedidos Ponderado", TypeName = "decimal(38, 6)")]
    public decimal? mts_kg_Pedidos_Ponderado { get; set; }

    [Column("Lista Precios")]
    [StringLength(7)]
    [Unicode(false)]
    public string? Lista_Precios { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Moneda { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Precio { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Cotización { get; set; }

    [Column(TypeName = "decimal(37, 6)")]
    public decimal? PrecioEnARS { get; set; }

    [Column("Bultos Totales")]
    public int? Bultos_Totales { get; set; }

    [Column("mts/kg Totales", TypeName = "decimal(38, 6)")]
    public decimal? mts_kg_Totales { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalEnARS { get; set; }
}
