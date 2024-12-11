using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vSaleOrderTraceability
{
    public int SaleOrderNumber { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string BusinessUnitName { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? SaleOrderDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime RequestedDate { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string SaleOrderStatusName { get; set; } = null!;

    [StringLength(201)]
    public string? SaleRepresentativeName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SaleChannelName { get; set; }

    public int? RequestedUnits { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ApprovalDate { get; set; }

    public int? PreparationNumber { get; set; }

    [Column(TypeName = "date")]
    public DateTime? PreparationDate { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PreparationStatusName { get; set; }

    public int? PreparedUnits { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? WarehouseGroupName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string DeliveryZoneName { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? SaleDeliveryNoteDate { get; set; }

    public int? SaleDeliveryNoteLegalNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? CurrencyID { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DeliveredDate { get; set; }

    public int? DeliveredUnits { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SaleDeliveryNoteStatusName { get; set; }

    [Unicode(false)]
    public string? SaleOrderRemarks { get; set; }
}
