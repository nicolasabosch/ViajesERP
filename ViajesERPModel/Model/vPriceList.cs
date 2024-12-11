using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vPriceList
{
    [StringLength(100)]
    [Unicode(false)]
    public string PriceListName { get; set; } = null!;

    [StringLength(200)]
    public string ProductTypeName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ProductFamilyID { get; set; } = null!;

    [StringLength(200)]
    public string ProductFamilyName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(200)]
    public string ProductName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ARS { get; set; }

    [Column("Dolar OF", TypeName = "decimal(18, 4)")]
    public decimal? Dolar_OF { get; set; }

    [Column("Dolar Blue", TypeName = "decimal(18, 4)")]
    public decimal? Dolar_Blue { get; set; }
}
