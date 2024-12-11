using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("DebitNoteID", "CheckID")]
public partial class DebitNoteCheck
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string DebitNoteID { get; set; } = null!;

    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CheckID { get; set; } = null!;

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? CheckStatusID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CheckStatusDescription { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("CheckID")]
    [InverseProperty("DebitNoteCheck")]
    public virtual Check Check { get; set; } = null!;

    [ForeignKey("CheckStatusID")]
    [InverseProperty("DebitNoteCheck")]
    public virtual CheckStatus? CheckStatus { get; set; }

    [ForeignKey("DebitNoteID")]
    [InverseProperty("DebitNoteCheck")]
    public virtual DebitNote DebitNote { get; set; } = null!;
}
