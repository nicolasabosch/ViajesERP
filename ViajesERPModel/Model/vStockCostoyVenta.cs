﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vStockCostoyVenta
{
    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(200)]
    public string Tipo { get; set; } = null!;

    [StringLength(200)]
    public string Familia { get; set; } = null!;

    [StringLength(200)]
    public string Marca { get; set; } = null!;

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

    [Column("Bultos Totales")]
    public int? Bultos_Totales { get; set; }

    [Column("mts/kg Totales", TypeName = "decimal(38, 6)")]
    public decimal? mts_kg_Totales { get; set; }

    [Column("Costo Unitario ARS", TypeName = "decimal(37, 6)")]
    public decimal? Costo_Unitario_ARS { get; set; }

    [Column("Costo Total ARS", TypeName = "decimal(18, 2)")]
    public decimal? Costo_Total_ARS { get; set; }

    [Column("Venta Unitario ARS", TypeName = "decimal(37, 6)")]
    public decimal? Venta_Unitario_ARS { get; set; }

    [Column("Venta Total ARS", TypeName = "decimal(18, 2)")]
    public decimal? Venta_Total_ARS { get; set; }
}
