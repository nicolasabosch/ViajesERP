using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class VendorPaymentAccountPayable
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string VendorPaymentAccountPayableID { get; set; } = null!;

    public int VendorPaymentAccountPayableNumber { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string VendorPaymentID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string AccountPayableID { get; set; } = null!;

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

    [ForeignKey("AccountPayableID")]
    [InverseProperty("VendorPaymentAccountPayable")]
    public virtual AccountPayable AccountPayable { get; set; } = null!;

    [ForeignKey("VendorPaymentID")]
    [InverseProperty("VendorPaymentAccountPayable")]
    public virtual VendorPayment VendorPayment { get; set; } = null!;
}
