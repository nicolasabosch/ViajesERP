using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vSaleOrderItem_SaleDeliveryItem
{
    public int SaleOrderNumber { get; set; }

    public int? SaleDeliveryNoteLegalNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? WarehousePositionID { get; set; }

    [Column(TypeName = "date")]
    public DateTime RequestedDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DeliveryDate { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    public int CustomerNumber { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SubCustomerName { get; set; }

    public int? SubCustomerNumber { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CurrencyName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? UnitPrice { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SubCustomerCurrencyName { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? SubCustomerUnitPrice { get; set; }

    [StringLength(200)]
    public string ProductName { get; set; } = null!;

    [StringLength(200)]
    public string ProductFamilyName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal RequestedQuantity { get; set; }

    [StringLength(200)]
    public string UnitOfMeasureName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? RequestedUnits { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal DeliveredQuantity { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal DeliveredUnits { get; set; }
}
