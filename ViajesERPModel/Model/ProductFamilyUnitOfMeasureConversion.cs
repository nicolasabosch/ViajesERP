using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("ProductFamilyID", "UnitOfMeasureID")]
public partial class ProductFamilyUnitOfMeasureConversion
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProductFamilyID { get; set; } = null!;

    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string UnitOfMeasureID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 6)")]
    public decimal ConvertedQuantity { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("ProductFamilyID")]
    [InverseProperty("ProductFamilyUnitOfMeasureConversion")]
    public virtual ProductFamily ProductFamily { get; set; } = null!;

    [ForeignKey("UnitOfMeasureID")]
    [InverseProperty("ProductFamilyUnitOfMeasureConversion")]
    public virtual UnitOfMeasure UnitOfMeasure { get; set; } = null!;
}
