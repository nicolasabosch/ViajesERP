using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Event
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string EventID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string EventName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("Event")]
    public virtual ICollection<TripEvent> TripEvent { get; } = new List<TripEvent>();
}
