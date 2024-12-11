using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ProductionStatus
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProductionStatusID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string ProductionStatusName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("ProductionStatus")]
    public virtual ICollection<Production> Production { get; } = new List<Production>();
}
