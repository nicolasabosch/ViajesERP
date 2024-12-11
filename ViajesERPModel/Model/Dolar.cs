using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class Dolar
{
    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("USD OF")]
    public double? USD_OF { get; set; }

    [Column("USD Compra")]
    public double? USD_Compra { get; set; }

    [Column("USD Venta")]
    public double? USD_Venta { get; set; }
}
