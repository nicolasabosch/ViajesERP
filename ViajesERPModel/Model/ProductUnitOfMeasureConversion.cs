using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("ProductID", "UnitOfMeasureID")]
public partial class ProductUnitOfMeasureConversion
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

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

    [ForeignKey("ProductID")]
    [InverseProperty("ProductUnitOfMeasureConversion")]
    public virtual Product Product { get; set; } = null!;

    [ForeignKey("UnitOfMeasureID")]
    [InverseProperty("ProductUnitOfMeasureConversion")]
    public virtual UnitOfMeasure UnitOfMeasure { get; set; } = null!;
}
