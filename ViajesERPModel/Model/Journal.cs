using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Journal
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string JournalID { get; set; } = null!;

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
    /// Tipo Documento
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentTypeID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string DocumentID { get; set; } = null!;

    /// <summary>
    /// U.O.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitID { get; set; } = null!;

    /// <summary>
    /// Entidad
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ThirdPartyID { get; set; }

    /// <summary>
    /// Concepto
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ExpenseTypeID { get; set; }

    /// <summary>
    /// Sub Concepto
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ExpenseSubTypeID { get; set; }

    /// <summary>
    /// Moneda
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ValueTypeID { get; set; } = null!;

    /// <summary>
    /// Cantidad de Valores
    /// </summary>
    public int ValueCount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal AmountInCurrency { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CurrencyRateAmount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "date")]
    public DateTime ImputationDate { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("Journal")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [ForeignKey("ChannelID")]
    [InverseProperty("Journal")]
    public virtual Channel Channel { get; set; } = null!;

    [ForeignKey("CurrencyID")]
    [InverseProperty("Journal")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("DocumentTypeID")]
    [InverseProperty("Journal")]
    public virtual DocumentType DocumentType { get; set; } = null!;

    [ForeignKey("OrganizationUnitID")]
    [InverseProperty("Journal")]
    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;

    [InverseProperty("Journal")]
    public virtual ICollection<SaleRepresentativePaymentValue> SaleRepresentativePaymentValue { get; } = new List<SaleRepresentativePaymentValue>();

    [ForeignKey("ValueTypeID")]
    [InverseProperty("Journal")]
    public virtual ValueType ValueType { get; set; } = null!;
}
