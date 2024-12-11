using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Country
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CountryID { get; set; } = null!;

    [StringLength(200)]
    public string CountryName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("Country")]
    public virtual ICollection<State> State { get; } = new List<State>();

    [InverseProperty("Country")]
    public virtual ICollection<Vendor> Vendor { get; } = new List<Vendor>();
}
