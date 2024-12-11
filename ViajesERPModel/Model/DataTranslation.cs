using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("ID", "FieldName", "LanguageID")]
public partial class DataTranslation
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ID { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string FieldName { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string LanguageID { get; set; } = null!;

    public int? Number { get; set; }

    [StringLength(1000)]
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
