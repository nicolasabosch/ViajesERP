using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Document
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentID { get; set; } = null!;

    /// <summary>
    /// Número NC
    /// </summary>
    public int DocumentNumber { get; set; }

    /// <summary>
    /// Fecha
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime DocumentDate { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    /// <summary>
    /// B.U.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SourceBusinessUnitID { get; set; } = null!;

    /// <summary>
    /// Canal
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ChannelID { get; set; } = null!;

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentTypeID { get; set; } = null!;

    /// <summary>
    /// Estado
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentStatusID { get; set; } = null!;

    /// <summary>
    /// Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string EntityID { get; set; } = null!;

    /// <summary>
    /// Moneda
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    /// <summary>
    /// Monto Total
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Comentarios
    /// </summary>
    [Unicode(false)]
    public string? Remarks { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("Document")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [ForeignKey("ChannelID")]
    [InverseProperty("Document")]
    public virtual Channel Channel { get; set; } = null!;

    [ForeignKey("CurrencyID")]
    [InverseProperty("Document")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("DocumentStatusID")]
    [InverseProperty("Document")]
    public virtual DocumentStatus DocumentStatus { get; set; } = null!;

    [ForeignKey("DocumentTypeID")]
    [InverseProperty("Document")]
    public virtual DocumentType DocumentType { get; set; } = null!;
}
