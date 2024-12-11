using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ValueType
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ValueTypeID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string ValueTypeName { get; set; } = null!;

    /// <summary>
    /// Estado Ingreso
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? InValueStatusID { get; set; }

    /// <summary>
    /// Estado Egreso
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? OutValueStatusID { get; set; }

    public bool EnabledOnReceipt { get; set; }

    public bool EnabledOnVendorPayment { get; set; }

    public bool EnabledOnCommissionPayment { get; set; }

    public bool ValueToPortfolio { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ValueTypeGroupID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("ValueType")]
    public virtual ICollection<BatchPaymentValue> BatchPaymentValue { get; } = new List<BatchPaymentValue>();

    [InverseProperty("ValueType")]
    public virtual ICollection<CashDeskValueType> CashDeskValueType { get; } = new List<CashDeskValueType>();

    [InverseProperty("ValueType")]
    public virtual ICollection<Journal> Journal { get; } = new List<Journal>();

    [InverseProperty("ValueType")]
    public virtual ICollection<PaymentDeclare> PaymentDeclare { get; } = new List<PaymentDeclare>();

    [InverseProperty("ValueType")]
    public virtual ICollection<ReceiptValue> ReceiptValue { get; } = new List<ReceiptValue>();

    [InverseProperty("ValueType")]
    public virtual ICollection<SaleRepresentativePaymentValue> SaleRepresentativePaymentValue { get; } = new List<SaleRepresentativePaymentValue>();

    [InverseProperty("ValueType")]
    public virtual ICollection<SaleRetailValue> SaleRetailValue { get; } = new List<SaleRetailValue>();

    [ForeignKey("ValueTypeGroupID")]
    [InverseProperty("ValueType")]
    public virtual ValueTypeGroup? ValueTypeGroup { get; set; }

    [InverseProperty("ValueType")]
    public virtual ICollection<VendorPaymentValue> VendorPaymentValue { get; } = new List<VendorPaymentValue>();
}
