using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ValueStatus
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ValueStatusID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string ValueStatusName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }
}
