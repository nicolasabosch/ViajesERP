using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class VendorPayment
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string VendorPaymentID { get; set; } = null!;

    /// <summary>
    /// Receipt Number
    /// </summary>
    public int VendorPaymentNumber { get; set; }

    /// <summary>
    /// Referencia
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? VendorPaymentCode { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime VendorPaymentDate { get; set; }

    /// <summary>
    /// U.O.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitID { get; set; } = null!;

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
    /// Customer Id
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string VendorID { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal VendorPaymentAmount { get; set; }

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

    /// <summary>
    /// Tipo de Pago
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string VendorPaymentClassID { get; set; } = null!;

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
    /// Período
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? PeriodID { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? CostCenterID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("VendorPayment")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [ForeignKey("ChannelID")]
    [InverseProperty("VendorPayment")]
    public virtual Channel Channel { get; set; } = null!;

    [ForeignKey("CostCenterID")]
    [InverseProperty("VendorPayment")]
    public virtual CostCenter? CostCenter { get; set; }

    [ForeignKey("DocumentStatusID")]
    [InverseProperty("VendorPayment")]
    public virtual DocumentStatus DocumentStatus { get; set; } = null!;

    [ForeignKey("ExpenseSubTypeID")]
    [InverseProperty("VendorPayment")]
    public virtual ExpenseSubType? ExpenseSubType { get; set; }

    [ForeignKey("ExpenseTypeID")]
    [InverseProperty("VendorPayment")]
    public virtual ExpenseType? ExpenseType { get; set; }

    [ForeignKey("OrganizationUnitID")]
    [InverseProperty("VendorPayment")]
    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;

    [InverseProperty("VendorPayment")]
    public virtual ICollection<VendorPaymentAccountPayable> VendorPaymentAccountPayable { get; } = new List<VendorPaymentAccountPayable>();

    [InverseProperty("VendorPayment")]
    public virtual ICollection<VendorPaymentValue> VendorPaymentValue { get; } = new List<VendorPaymentValue>();
}
