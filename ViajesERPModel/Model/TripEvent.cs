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
    public string FileID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string Latitude { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string Longitude { get; set; } = null!;

    public int EventID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string SourceID { get; set; } = null!;

    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public DateTimeOffset CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    public DateTimeOffset LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string LastModifiedBy { get; set; } = null!;

    [ForeignKey("EventID")]
    [InverseProperty("TripEvent")]
    public virtual Event Event { get; set; } = null!;

    [ForeignKey("FileID")]
    [InverseProperty("TripEvent")]
    public virtual File File { get; set; } = null!;

    [ForeignKey("SaleDeliveryID")]
    [InverseProperty("TripEvent")]
    public virtual SaleDelivery SaleDelivery { get; set; } = null!;

    [ForeignKey("TripID")]
    [InverseProperty("TripEvent")]
    public virtual Trip Trip { get; set; } = null!;
}
