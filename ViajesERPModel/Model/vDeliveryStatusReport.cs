using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vDeliveryStatusReport
{
    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string FinalCustomerName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CurrencyRateAmount { get; set; }

    [Column(TypeName = "date")]
    public DateTime? SaleDeliveryNoteDate { get; set; }

    public int? Urgency { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? UrgencyID { get; set; }

    [StringLength(200)]
    public string UrgencyName { get; set; } = null!;

    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? DeliveryStatusID { get; set; }

    [StringLength(200)]
    public string DeliveryStatusName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? DeliveryStatusDescription { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal SaleDeliveryCurrencyRate { get; set; }

    [StringLength(92)]
    [Unicode(false)]
    public string? DeliveryCode { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CustomerLegalName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FiscalCode { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DistrictName { get; set; }
}
