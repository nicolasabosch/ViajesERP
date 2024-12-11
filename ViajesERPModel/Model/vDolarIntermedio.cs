using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vDolarIntermedio
{
    [Column(TypeName = "date")]
    public DateTime CurrencyRateDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CurrencyRateAmounteInUSD { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CurrencyRateAmounteInUSDB { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? USDAVG { get; set; }
}
