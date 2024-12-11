using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Audit
{
    [Key]
    public long AuditID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string TableKeyValues { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string AuditType { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [InverseProperty("Audit")]
    public virtual ICollection<AuditDetail> AuditDetail { get; } = new List<AuditDetail>();
}
