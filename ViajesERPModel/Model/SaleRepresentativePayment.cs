using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class SaleRepresentativePayment
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRepresentativePaymentID { get; set; } = null!;

    /// <summary>
    /// Receipt Number
    /// </summary>
    public int SaleRepresentativePaymentNumber { get; set; }

    /// <summary>
    /// Referencia
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? SaleRepresentativePaymentCode { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime SaleRepresentativePaymentDate { get; set; }

    /// <summary>
    /// U.O.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitID { get; set; } = null!;

    /// <summary>
    /// Customer Id
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRepresentativeID { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal SaleRepresentativePaymentAmount { get; set; }

    /// <summary>
    /// B.U.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? BusinessUnitID { get; set; }

    /// <summary>
    /// Cotización Dolar
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal CurrencyRateAmount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? AdvancedPaymentAmount { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentStatusID { get; set; } = null!;

    /// <summary>
    /// Remarks
    /// </summary>
    [StringLength(4000)]
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
    [InverseProperty("SaleRepresentativePayment")]
    public virtual BusinessUnit? BusinessUnit { get; set; }

    [ForeignKey("DocumentStatusID")]
    [InverseProperty("SaleRepresentativePayment")]
    public virtual DocumentStatus DocumentStatus { get; set; } = null!;

    [ForeignKey("OrganizationUnitID")]
    [InverseProperty("SaleRepresentativePayment")]
    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;

    [ForeignKey("SaleRepresentativeID")]
    [InverseProperty("SaleRepresentativePayment")]
    public virtual User SaleRepresentative { get; set; } = null!;

    [InverseProperty("SaleRepresentativePayment")]
    public virtual ICollection<SaleRepresentativePaymentCommissionPayable> SaleRepresentativePaymentCommissionPayable { get; } = new List<SaleRepresentativePaymentCommissionPayable>();

    [InverseProperty("SaleRepresentativePayment")]
    public virtual ICollection<SaleRepresentativePaymentValue> SaleRepresentativePaymentValue { get; } = new List<SaleRepresentativePaymentValue>();
}
