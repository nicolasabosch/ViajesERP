using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("ProjectID", "ToolID")]
public partial class ProjectTool
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    public int ProjectID { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ToolID { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("ProjectID")]
    [InverseProperty("ProjectTool")]
    public virtual Project Project { get; set; } = null!;

    [ForeignKey("ToolID")]
    [InverseProperty("ProjectTool")]
    public virtual Tool Tool { get; set; } = null!;
}
