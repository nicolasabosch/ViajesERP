using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vTotalSaleDeliveryItem
{
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryID { get; set; } = null!;

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? TotalAmount { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? OtherPriceCurrencyID { get; set; }
}
