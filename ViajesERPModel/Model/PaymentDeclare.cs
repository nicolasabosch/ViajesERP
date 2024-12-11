using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class PaymentDeclare
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    public int PaymentDeclareID { get; set; }

    /// <summary>
    /// Fecha
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime PaymentDeclareDate { get; set; }

    /// <summary>
    /// O. U.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? OrganizationUnitID { get; set; }

    /// <summary>
    /// Tipo Valor
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ValueTypeID { get; set; } = null!;

    /// <summary>
    /// Monto
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal PaymentDeclareTotalAmount { get; set; }

    /// <summary>
    /// Comisión
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal PaymentDeclareCommissionAmount { get; set; }

    [Unicode(false)]
    public string? PaymentDeclareJSON { get; set; }

    /// <summary>
    /// Comentarios
    /// </summary>
    [StringLength(5000)]
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

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CurrencyRate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? CommissionPercent { get; set; }

    [ForeignKey("OrganizationUnitID")]
    [InverseProperty("PaymentDeclare")]
    public virtual OrganizationUnit? OrganizationUnit { get; set; }

    [ForeignKey("ValueTypeID")]
    [InverseProperty("PaymentDeclare")]
    public virtual ValueType ValueType { get; set; } = null!;
}
