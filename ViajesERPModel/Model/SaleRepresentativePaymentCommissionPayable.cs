using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class SaleRepresentativePaymentCommissionPayable
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRepresentativePaymentCommissionPayableID { get; set; } = null!;

    public int SaleRepresentativePaymentCommissionPayableNumber { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRepresentativePaymentID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string CommissionPayableID { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal AppliedAmount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal AppliedAmountInCurrency { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CurrencyRateAmount { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("CommissionPayableID")]
    [InverseProperty("SaleRepresentativePaymentCommissionPayable")]
    public virtual CommissionPayable CommissionPayable { get; set; } = null!;

    [ForeignKey("SaleRepresentativePaymentID")]
    [InverseProperty("SaleRepresentativePaymentCommissionPayable")]
    public virtual SaleRepresentativePayment SaleRepresentativePayment { get; set; } = null!;
}
