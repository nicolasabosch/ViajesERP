using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class zvDeliveryItemStatusReportORIG
{
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryNoteID { get; set; } = null!;

    [StringLength(200)]
    public string ProductFamilyName { get; set; } = null!;

    [StringLength(200)]
    public string UnitOfMeasureName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal UnitPrice { get; set; }

    public int? VariantCount { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? TotalDeliveredQuantity { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? TotalDeliveredUnits { get; set; }
}
