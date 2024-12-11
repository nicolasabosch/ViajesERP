using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class CheckStatus
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CheckStatusID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string CheckStatusName { get; set; } = null!;

    /// <summary>
    /// Etapa
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string StageCode { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("CheckStatus")]
    public virtual ICollection<BatchPaymentValue> BatchPaymentValue { get; } = new List<BatchPaymentValue>();

    [InverseProperty("CheckStatus")]
    public virtual ICollection<DebitNoteCheck> DebitNoteCheck { get; } = new List<DebitNoteCheck>();

    [InverseProperty("CheckStatus")]
    public virtual ICollection<SaleRetailValue> SaleRetailValue { get; } = new List<SaleRetailValue>();
}
