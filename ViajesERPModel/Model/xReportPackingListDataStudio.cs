using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class xReportPackingListDataStudio
{
    [Column("N° DE ORDEN")]
    [StringLength(36)]
    [Unicode(false)]
    public string? N__DE_ORDEN { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TEMPORADA { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string UN { get; set; } = null!;

    [StringLength(200)]
    public string PROVEEDOR { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? NroContenedor { get; set; }

    [Unicode(false)]
    public string? CODUN_CONT { get; set; }

    [Column(TypeName = "decimal(38, 20)")]
    public decimal? CUENTA_CNTR { get; set; }

    [StringLength(200)]
    public string TELA { get; set; } = null!;

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? ROLLOS { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? CONT { get; set; }

    [StringLength(200)]
    public string UNIDAD { get; set; } = null!;

    [Column("ROLLOS P", TypeName = "decimal(38, 2)")]
    public decimal? ROLLOS_P { get; set; }

    [Column("CONT PEDIDO", TypeName = "decimal(38, 2)")]
    public decimal? CONT_PEDIDO { get; set; }

    [Column("FOB UNIT", TypeName = "decimal(18, 4)")]
    public decimal FOB_UNIT { get; set; }

    [Column("FOB TOTAL", TypeName = "decimal(38, 6)")]
    public decimal? FOB_TOTAL { get; set; }

    [Column("FECHA EMBARQUE")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FECHA_EMBARQUE { get; set; }

    [Column("FECHA ARRIBO")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FECHA_ARRIBO { get; set; }

    [Column("FECHA ENTREGA")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FECHA_ENTREGA { get; set; }

    [StringLength(200)]
    public string CountryName { get; set; } = null!;

    [StringLength(200)]
    public string? ManufacturerName { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string StatusName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? ProductSeasonalityName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ProductCompositionName { get; set; }
}
