using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class UnitOfMeasure
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string UnitOfMeasureID { get; set; } = null!;

    [StringLength(200)]
    public string UnitOfMeasureName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("UnitOfMeasure")]
    public virtual ICollection<CreditNoteItem> CreditNoteItem { get; } = new List<CreditNoteItem>();

    [InverseProperty("UnitOfMeasure")]
    public virtual ICollection<Product> Product { get; } = new List<Product>();

    [InverseProperty("UnitOfMeasure")]
    public virtual ICollection<ProductFamily> ProductFamily { get; } = new List<ProductFamily>();

    [InverseProperty("UnitOfMeasure")]
    public virtual ICollection<ProductFamilyUnitOfMeasureConversion> ProductFamilyUnitOfMeasureConversion { get; } = new List<ProductFamilyUnitOfMeasureConversion>();

    [InverseProperty("UnitOfMeasure")]
    public virtual ICollection<ProductUnitOfMeasureConversion> ProductUnitOfMeasureConversion { get; } = new List<ProductUnitOfMeasureConversion>();

    [InverseProperty("UnitOfMeasure")]
    public virtual ICollection<PurchaseDeliveryDetail> PurchaseDeliveryDetail { get; } = new List<PurchaseDeliveryDetail>();

    [InverseProperty("UnitOfMeasure")]
    public virtual ICollection<PurchaseOrderItem> PurchaseOrderItem { get; } = new List<PurchaseOrderItem>();

    [InverseProperty("UnitOfMeasure")]
    public virtual ICollection<SaleDeliveryNoteItem> SaleDeliveryNoteItem { get; } = new List<SaleDeliveryNoteItem>();

    [InverseProperty("UnitOfMeasure")]
    public virtual ICollection<TransferOrderItem> TransferOrderItem { get; } = new List<TransferOrderItem>();

    [InverseProperty("UnitOfMeasure")]
    public virtual ICollection<WithdrawalOrderItem> WithdrawalOrderItem { get; } = new List<WithdrawalOrderItem>();
}
