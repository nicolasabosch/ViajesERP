using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Language
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string LanguageID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? LanguageName { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }
}
