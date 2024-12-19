using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class TripEvent
{
    [Key]
    public int TripEventID { get; set; }

    public int TripID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? FileID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleDeliveryID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? Latitude { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? Longitude { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string EventID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? SourceID { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("EventID")]
    [InverseProperty("TripEvent")]
    public virtual Event Event { get; set; } = null!;

    [ForeignKey("FileID")]
    [InverseProperty("TripEvent")]
    public virtual File? File { get; set; }

    [ForeignKey("SaleDeliveryID")]
    [InverseProperty("TripEvent")]
    public virtual SaleDelivery? SaleDelivery { get; set; }

    [ForeignKey("TripID")]
    [InverseProperty("TripEvent")]
    public virtual Trip Trip { get; set; } = null!;
}
