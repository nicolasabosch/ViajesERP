using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Index("ProductBrandID", Name = "IX_Product_ProductBrandID")]
[Index("ProductCode", Name = "IX_Product_ProductCode")]
[Index("ProductConditionID", Name = "IX_Product_ProductConditionID")]
[Index("ProductFamilyID", Name = "IX_Product_ProductFamilyID")]
[Index("ProductName", Name = "IX_Product_ProductName")]
[Index("UnitOfMeasureID", Name = "IX_Product_UnitOfMeasureID")]
public partial class Product
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(200)]
    public string ProductName { get; set; } = null!;

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string ProductCode { get; set; } = null!;

    /// <summary>
    /// Familia
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ProductFamilyID { get; set; } = null!;

    /// <summary>
    /// Marca
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ProductBrandID { get; set; } = null!;

    /// <summary>
    /// Medida
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? UnitOfMeasureID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? FileID { get; set; }

    /// <summary>
    /// Clase
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ProductClassID { get; set; }

    /// <summary>
    /// Condición
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ProductConditionID { get; set; }

    /// <summary>
    /// Estado de Ingreso
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? DefaultInputProductStatusID { get; set; }

    /// <summary>
    /// Activo
    /// </summary>
    public bool Active { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AlternativeCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BarCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Size { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Composition { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SpecificWeight { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ColorDesign { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? ParentProductID { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal? Yield { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<CountOrderItem> CountOrderItem { get; } = new List<CountOrderItem>();

    [InverseProperty("Product")]
    public virtual ICollection<CreditNoteItem> CreditNoteItem { get; } = new List<CreditNoteItem>();

    [ForeignKey("DefaultInputProductStatusID")]
    [InverseProperty("Product")]
    public virtual ProductStatus? DefaultInputProductStatus { get; set; }

    [ForeignKey("FileID")]
    [InverseProperty("Product")]
    public virtual File? File { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<Inventory> Inventory { get; } = new List<Inventory>();

    [InverseProperty("Product")]
    public virtual ICollection<InventoryBarCode> InventoryBarCode { get; } = new List<InventoryBarCode>();

    [InverseProperty("Product")]
    public virtual ICollection<InventoryTransfer> InventoryTransfer { get; } = new List<InventoryTransfer>();

    [InverseProperty("Product")]
    public virtual ICollection<PriceListProduct> PriceListProduct { get; } = new List<PriceListProduct>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductBOM> ProductBOM { get; } = new List<ProductBOM>();

    [ForeignKey("ProductBrandID")]
    [InverseProperty("Product")]
    public virtual ProductBrand ProductBrand { get; set; } = null!;

    [InverseProperty("Product")]
    public virtual ICollection<ProductBusinessUnit> ProductBusinessUnit { get; } = new List<ProductBusinessUnit>();

    [ForeignKey("ProductClassID")]
    [InverseProperty("Product")]
    public virtual ProductClass? ProductClass { get; set; }

    [ForeignKey("ProductConditionID")]
    [InverseProperty("Product")]
    public virtual ProductCondition? ProductCondition { get; set; }

    [ForeignKey("ProductFamilyID")]
    [InverseProperty("Product")]
    public virtual ProductFamily ProductFamily { get; set; } = null!;

    [InverseProperty("Product")]
    public virtual ICollection<ProductTag> ProductTag { get; } = new List<ProductTag>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductUnitOfMeasureConversion> ProductUnitOfMeasureConversion { get; } = new List<ProductUnitOfMeasureConversion>();

    [InverseProperty("Product")]
    public virtual ICollection<Production> Production { get; } = new List<Production>();

    [InverseProperty("Product")]
    public virtual ICollection<PurchaseOrderItem> PurchaseOrderItem { get; } = new List<PurchaseOrderItem>();

    [InverseProperty("Product")]
    public virtual ICollection<SaleDeliveryNoteItem> SaleDeliveryNoteItem { get; } = new List<SaleDeliveryNoteItem>();

    [InverseProperty("Product")]
    public virtual ICollection<SaleRetailItem> SaleRetailItem { get; } = new List<SaleRetailItem>();

    [InverseProperty("Product")]
    public virtual ICollection<TransferOrderItem> TransferOrderItem { get; } = new List<TransferOrderItem>();

    [ForeignKey("UnitOfMeasureID")]
    [InverseProperty("Product")]
    public virtual UnitOfMeasure? UnitOfMeasure { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<WithdrawalOrderItem> WithdrawalOrderItem { get; } = new List<WithdrawalOrderItem>();
}
