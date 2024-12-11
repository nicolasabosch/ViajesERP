using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vSaleDeliveryNoteItem
{
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryNoteID { get; set; } = null!;

    public int SaleDeliveryNoteItemNumber { get; set; }

    [StringLength(200)]
    public string ProductFamilyName { get; set; } = null!;

    [StringLength(200)]
    public string ProductName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal DeliveredQuantity { get; set; }

    public int? DeliveredUnits { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal UnitPrice { get; set; }

    [StringLength(200)]
    public string UnitOfMeasureName { get; set; } = null!;
}
