using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ProductBOM
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProductBOMID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ComponentProductID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ComponentQuantity { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("ProductID")]
    [InverseProperty("ProductBOM")]
    public virtual Product Product { get; set; } = null!;
}
