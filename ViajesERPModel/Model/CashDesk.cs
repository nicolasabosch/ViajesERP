using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class CashDesk
{
    /// <summary>
    /// U.O.
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CashDeskID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime CashDeskDate { get; set; }

    /// <summary>
    /// U.O.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitID { get; set; } = null!;

    /// <summary>
    /// Cotización Dolar Apertura
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal OpenCurrencyRateAmount { get; set; }

    /// <summary>
    /// Cotización Dolar Cierre
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal CloseCurrencyRateAmount { get; set; }

    /// <summary>
    /// Dolares Apertura Calculado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal CalculatedOpenAmountUSD { get; set; }

    /// <summary>
    /// Pesos Apertura Calculado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal CalculatedOpenAmountARS { get; set; }

    /// <summary>
    /// Dolares Apertura Real
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal RealOpenAmountUSD { get; set; }

    /// <summary>
    /// Pesos Apertura Real
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal RealOpenAmountARS { get; set; }

    /// <summary>
    /// Dolares Cierre Calculado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CalculatedCloseAmountUSD { get; set; }

    /// <summary>
    /// Pesos Cierre Calculado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CalculatedCloseAmountARS { get; set; }

    /// <summary>
    /// Dolares Cierre Real
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? RealCloseAmountUSD { get; set; }

    /// <summary>
    /// Pesos Cierre Real
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? RealCloseAmountARS { get; set; }

    /// <summary>
    /// Comentarios
    /// </summary>
    [StringLength(5000)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string CashDeskStatus { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("CashDesk")]
    public virtual ICollection<CashDeskValueType> CashDeskValueType { get; } = new List<CashDeskValueType>();

    [ForeignKey("OrganizationUnitID")]
    [InverseProperty("CashDesk")]
    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;
}
