using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vCurrencyRateAvg
{
    public int ID { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CurrencyRateAvg { get; set; }
}
