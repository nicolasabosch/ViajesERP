using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vCurrencyRate
{
    [Column(TypeName = "date")]
    public DateTime CurrencyRateDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ARSPerUSDOf { get; set; }

    [Column(TypeName = "decimal(38, 20)")]
    public decimal? USDBluePerUSDOf { get; set; }

    [Column(TypeName = "decimal(23, 6)")]
    public decimal? ARSPerUSDOfAVG { get; set; }
}
