﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vReceiptSumByCurrencyHasta20240905
{
    [StringLength(36)]
    [Unicode(false)]
    public string ReceiptID { get; set; } = null!;

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? ARS { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? USDB { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? USDOF { get; set; }
}
