using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Bank
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string BankID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string BankName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("Bank")]
    public virtual ICollection<BatchPaymentValue> BatchPaymentValue { get; } = new List<BatchPaymentValue>();

    [InverseProperty("Bank")]
    public virtual ICollection<ReceiptValue> ReceiptValue { get; } = new List<ReceiptValue>();

    [InverseProperty("Bank")]
    public virtual ICollection<SaleRepresentativePaymentValue> SaleRepresentativePaymentValue { get; } = new List<SaleRepresentativePaymentValue>();

    [InverseProperty("Bank")]
    public virtual ICollection<SaleRetailValue> SaleRetailValue { get; } = new List<SaleRetailValue>();

    [InverseProperty("Bank")]
    public virtual ICollection<VendorPaymentValue> VendorPaymentValue { get; } = new List<VendorPaymentValue>();
}
