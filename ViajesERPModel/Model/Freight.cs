using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Freight
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string FreightID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string FreightName { get; set; } = null!;

    /// <summary>
    /// Activo
    /// </summary>
    public bool Active { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("Freight")]
    public virtual ICollection<Trip> Trip { get; } = new List<Trip>();
}
