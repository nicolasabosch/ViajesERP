using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class RuleField
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string RuleFieldID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string RuleFieldName { get; set; } = null!;

    /// <summary>
    /// Campo
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string ReferenceFieldName { get; set; } = null!;

    /// <summary>
    /// HTML
    /// </summary>
    [Unicode(false)]
    public string RuleFieldHTML { get; set; } = null!;

    /// <summary>
    /// Datos
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string RuleFieldData { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }
}
