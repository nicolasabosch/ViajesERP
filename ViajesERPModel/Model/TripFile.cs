using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class TripFile
{
    [Key]
    public int TripFileID { get; set; }

    public int TripID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? FileID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleDeliveryID { get; set; }

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

    [ForeignKey("FileID")]
    [InverseProperty("TripFile")]
    public virtual File? File { get; set; }

    [ForeignKey("SaleDeliveryID")]
    [InverseProperty("TripFile")]
    public virtual SaleDelivery? SaleDelivery { get; set; }

    [ForeignKey("TripID")]
    [InverseProperty("TripFile")]
    public virtual Trip Trip { get; set; } = null!;
}
