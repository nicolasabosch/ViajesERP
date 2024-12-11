using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vSaleDeliveryNoteTotal
{
    public int SaleOrderNumber { get; set; }

    public int SaleDeliveryNumber { get; set; }

    public int SaleDeliveryNoteNumber { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CurrencyName { get; set; } = null!;

    [StringLength(65)]
    [Unicode(false)]
    public string? DocumentLegalCode { get; set; }

    [Column(TypeName = "date")]
    public DateTime? SaleDeliveryNoteDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string BusinessUnitName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string WarehouseName { get; set; } = null!;

    [StringLength(233)]
    [Unicode(false)]
    public string? CustomerName { get; set; }

    [StringLength(233)]
    [Unicode(false)]
    public string? SubCustomerName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CarrierName { get; set; }

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
