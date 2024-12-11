using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("CashDeskID", "ValueTypeID")]
public partial class CashDeskValueType
{
    /// <summary>
    /// U.O.
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CashDeskID { get; set; } = null!;

    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ValueTypeID { get; set; } = null!;

    /// <summary>
    /// Dolares Apertura Calculado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal OpenAmount { get; set; }

    public short OpenValueCount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal DayAmount { get; set; }

    public short DayValueCount { get; set; }

    /// <summary>
    /// Dolares Cierre Calculado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CloseAmount { get; set; }

    public short CloseValueCount { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("CashDeskID")]
    [InverseProperty("CashDeskValueType")]
    public virtual CashDesk CashDesk { get; set; } = null!;

    [ForeignKey("ValueTypeID")]
    [InverseProperty("CashDeskValueType")]
    public virtual ValueType ValueType { get; set; } = null!;
}
