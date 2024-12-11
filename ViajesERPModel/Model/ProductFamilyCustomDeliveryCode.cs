using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Index("ProductFamilyID", Name = "IX_ProductFamilyCustomDeliveryCode", IsUnique = true)]
public partial class ProductFamilyCustomDeliveryCode
{
    /// <summary>
    /// Familia
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProductFamilyCustomDeliveryCodeID { get; set; } = null!;

    /// <summary>
    /// Familia
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ProductFamilyID { get; set; } = null!;

    /// <summary>
    /// Despacho
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string CustomDeliveryCode { get; set; } = null!;

    /// <summary>
    /// Canal
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? LabelTypeID { get; set; }

    public int? TotalQuantity { get; set; }

    public int? OpenQuantity { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("LabelTypeID")]
    [InverseProperty("ProductFamilyCustomDeliveryCode")]
    public virtual LabelType? LabelType { get; set; }

    [ForeignKey("ProductFamilyID")]
    [InverseProperty("ProductFamilyCustomDeliveryCode")]
    public virtual ProductFamily ProductFamily { get; set; } = null!;
}
