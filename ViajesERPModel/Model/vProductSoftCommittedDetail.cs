using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vProductSoftCommittedDetail
{
    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(200)]
    public string Productname { get; set; } = null!;

    public int SaleOrderNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string SaleOrderStatusID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string SaleOrderStatusName { get; set; } = null!;

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? RequestedQuantity { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? RequestedUnits { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? DeliveredQuantity { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? DeliveredUnits { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? OpenQuantity { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? OpenUnits { get; set; }
}
