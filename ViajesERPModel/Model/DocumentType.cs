using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class DocumentType
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentTypeID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string DocumentTypeName { get; set; } = null!;

    /// <summary>
    /// Clase
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentClassID { get; set; } = null!;

    /// <summary>
    /// Débito/Crédito
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string DebitCredit { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("DocumentType")]
    public virtual ICollection<AccountPayable> AccountPayable { get; } = new List<AccountPayable>();

    [InverseProperty("DocumentType")]
    public virtual ICollection<AccountReceivable> AccountReceivable { get; } = new List<AccountReceivable>();

    [InverseProperty("DocumentType")]
    public virtual ICollection<CommissionPayable> CommissionPayable { get; } = new List<CommissionPayable>();

    [InverseProperty("DocumentType")]
    public virtual ICollection<Document> Document { get; } = new List<Document>();

    [ForeignKey("DocumentClassID")]
    [InverseProperty("DocumentType")]
    public virtual DocumentClass DocumentClass { get; set; } = null!;

    [InverseProperty("DocumentType")]
    public virtual ICollection<DocumentSubType> DocumentSubType { get; } = new List<DocumentSubType>();

    [InverseProperty("DocumentType")]
    public virtual ICollection<Journal> Journal { get; } = new List<Journal>();
}
