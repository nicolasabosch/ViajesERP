using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ProjectFile
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProjectFileID { get; set; } = null!;

    /// <summary>
    /// Código
    /// </summary>
    public int ProjectID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string FileID { get; set; } = null!;

    [StringLength(500)]
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
    [InverseProperty("ProjectFile")]
    public virtual File File { get; set; } = null!;

    [ForeignKey("ProjectID")]
    [InverseProperty("ProjectFile")]
    public virtual Project Project { get; set; } = null!;
}
