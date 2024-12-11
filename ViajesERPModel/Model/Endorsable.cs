using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Endorsable
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string EndorsableID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string EndorsableName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }
}
