using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vTripReport
{
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryID { get; set; } = null!;

    public int SaleDeliveryNumber { get; set; }

    [StringLength(92)]
    [Unicode(false)]
    public string? DeliveryCode { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? CustomerID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CustomerName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? FinalCustomerID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? FinalCustomerName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CustomerLegalName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FiscalCode { get; set; }

    [Column(TypeName = "date")]
    public DateTime DeliveryDate { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? DeliveryStatusID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ZipCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DistrictName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? SaleDeliveryStatusID { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? DeliveryZoneID { get; set; }

    public int? TripOrder { get; set; }

    public int? BundlesQuantity { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? TripID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TripCode { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TripName { get; set; }

    [Column(TypeName = "date")]
    public DateTime? TripDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? TripStatusID { get; set; }
}
