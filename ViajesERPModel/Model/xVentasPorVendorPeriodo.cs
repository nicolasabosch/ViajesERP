﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class xVentasPorVendorPeriodo
{
    [StringLength(500)]
    [Unicode(false)]
    public string? Period { get; set; }

    [StringLength(201)]
    public string? Vendedor { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? VentasUSDOficial { get; set; }
}
