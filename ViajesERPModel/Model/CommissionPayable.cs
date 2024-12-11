using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class CommissionPayable
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CommissionPayableID { get; set; } = null!;

    public int CommissionPayableNumber { get; set; }

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

    /// <summary>
    /// B.U.
    /// </summary>
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
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal OpenAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal DocumentAppliedAmount { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? ReceiptID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("CommissionPayable")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [ForeignKey("ChannelID")]
    [InverseProperty("CommissionPayable")]
    public virtual Channel Channel { get; set; } = null!;

    [ForeignKey("CurrencyID")]
    [InverseProperty("CommissionPayable")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("DocumentTypeID")]
    [InverseProperty("CommissionPayable")]
    public virtual DocumentType DocumentType { get; set; } = null!;

    [ForeignKey("SaleRepresentativeID")]
    [InverseProperty("CommissionPayable")]
    public virtual User SaleRepresentative { get; set; } = null!;

    [InverseProperty("CommissionPayable")]
    public virtual ICollection<SaleRepresentativePaymentCommissionPayable> SaleRepresentativePaymentCommissionPayable { get; } = new List<SaleRepresentativePaymentCommissionPayable>();
}
