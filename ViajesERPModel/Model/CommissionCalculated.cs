using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class CommissionCalculated
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CommissionCalculatedID { get; set; } = null!;

    /// <summary>
    /// Vendedor
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRepresentativeID { get; set; } = null!;

    /// <summary>
    /// Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? CustomerID { get; set; }

    /// <summary>
    /// Sub Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SubCustomerID { get; set; }

    /// <summary>
    /// Tipo Documento
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentTypeID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string DocumentID { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? DocumentDate { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? SourceBusinessUnitID { get; set; }

    /// <summary>
    /// Canal
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ChannelID { get; set; } = null!;

    /// <summary>
    /// Moneda
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal DocumentAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal CommissionAmount { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }
}
