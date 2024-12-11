using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ProductFamily
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProductFamilyID { get; set; } = null!;

    [StringLength(200)]
    public string ProductFamilyName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ProductTypeID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string UnitOfMeasureID { get; set; } = null!;

    [StringLength(200)]
    public string? ProductFamilyDescription { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ProductCompositionID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? ProductSeasonalityID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? CountryID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? ProductGroupID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? ProductCategoryID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ProductFamilyCatalogName { get; set; }

    [InverseProperty("ProductFamily")]
    public virtual ICollection<CountOrder> CountOrder { get; } = new List<CountOrder>();

    [InverseProperty("ProductFamily")]
    public virtual ICollection<PriceListProductFamily> PriceListProductFamily { get; } = new List<PriceListProductFamily>();

    [InverseProperty("ProductFamily")]
    public virtual ICollection<Product> Product { get; } = new List<Product>();

    [ForeignKey("ProductCategoryID")]
    [InverseProperty("ProductFamily")]
    public virtual ProductCategory? ProductCategory { get; set; }

    [ForeignKey("ProductCompositionID")]
    [InverseProperty("ProductFamily")]
    public virtual ProductComposition? ProductComposition { get; set; }

    [InverseProperty("ProductFamily")]
    public virtual ProductFamilyCustomDeliveryCode? ProductFamilyCustomDeliveryCode { get; set; }

    [InverseProperty("ProductFamily")]
    public virtual ICollection<ProductFamilyUnitOfMeasureConversion> ProductFamilyUnitOfMeasureConversion { get; } = new List<ProductFamilyUnitOfMeasureConversion>();

    [ForeignKey("ProductGroupID")]
    [InverseProperty("ProductFamily")]
    public virtual ProductGroup? ProductGroup { get; set; }

    [ForeignKey("ProductSeasonalityID")]
    [InverseProperty("ProductFamily")]
    public virtual ProductSeasonality? ProductSeasonality { get; set; }

    [ForeignKey("ProductTypeID")]
    [InverseProperty("ProductFamily")]
    public virtual ProductType ProductType { get; set; } = null!;

    [ForeignKey("UnitOfMeasureID")]
    [InverseProperty("ProductFamily")]
    public virtual UnitOfMeasure UnitOfMeasure { get; set; } = null!;
}
