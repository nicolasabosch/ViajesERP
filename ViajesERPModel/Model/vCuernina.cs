using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vCuernina
{
    [Column(TypeName = "date")]
    public DateTime? SaleDeliveryNoteDate { get; set; }

    [StringLength(200)]
    public string ProductName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal DeliveredQuantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal DeliveredUnits { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal UnitPrice { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;
}
