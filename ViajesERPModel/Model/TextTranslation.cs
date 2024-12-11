using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("Text", "LanguageID")]
public partial class TextTranslation
{
    [Key]
    [StringLength(800)]
    [Unicode(false)]
    public string Text { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string LanguageID { get; set; } = null!;

    [StringLength(2000)]
    public string Translation { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }
}
