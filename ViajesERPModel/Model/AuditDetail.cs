using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("AuditID", "FieldName")]
public partial class AuditDetail
{
    [Key]
    public long AuditID { get; set; }

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string FieldName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    [ForeignKey("AuditID")]
    [InverseProperty("AuditDetail")]
    public virtual Audit Audit { get; set; } = null!;
}
