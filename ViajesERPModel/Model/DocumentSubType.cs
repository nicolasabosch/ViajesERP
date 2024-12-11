using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class DocumentSubType
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentSubTypeID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string DocumentSubTypeName { get; set; } = null!;

    /// <summary>
    /// Tipo
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentTypeID { get; set; } = null!;

    public bool Manual { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("DocumentSubType")]
    public virtual ICollection<CreditNote> CreditNote { get; } = new List<CreditNote>();

    [InverseProperty("DocumentSubType")]
    public virtual ICollection<DebitNote> DebitNote { get; } = new List<DebitNote>();

    [ForeignKey("DocumentTypeID")]
    [InverseProperty("DocumentSubType")]
    public virtual DocumentType DocumentType { get; set; } = null!;
}
