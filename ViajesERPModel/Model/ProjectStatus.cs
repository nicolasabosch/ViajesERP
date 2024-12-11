using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ProjectStatus
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProjectStatusID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string ProjectStatusName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("ProjectStatus")]
    public virtual ICollection<Project> Project { get; } = new List<Project>();
}
