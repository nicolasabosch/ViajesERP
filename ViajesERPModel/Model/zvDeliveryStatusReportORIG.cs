using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class zvDeliveryStatusReportORIG
{
    [StringLength(200)]
    [Unicode(false)]
    public string FinalCustomerName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryNoteID { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? SaleDeliveryNoteDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? UrgencyID { get; set; }

    public int? Urgency { get; set; }

    [StringLength(200)]
    public string UrgencyName { get; set; } = null!;

    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? DeliveryStatusID { get; set; }

    [StringLength(200)]
    public string DeliveryStatusName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CurrencyName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CurrencyRate { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? DeliveryStatusDescription { get; set; }

    [StringLength(92)]
    [Unicode(false)]
    public string? DeliveryCode { get; set; }
}
