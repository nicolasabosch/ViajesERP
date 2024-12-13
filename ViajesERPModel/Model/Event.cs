using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Event
{
    [Key]
    public int EventID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string EventName { get; set; } = null!;

    [InverseProperty("Event")]
    public virtual ICollection<TripEvent> TripEvent { get; } = new List<TripEvent>();
}
