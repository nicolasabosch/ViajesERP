using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ProductCategory
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProductCategoryID { get; set; } = null!;

    [StringLength(200)]
    public string ProductCategoryName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    public int DisplayOrder { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? FileID { get; set; }

    [ForeignKey("FileID")]
    [InverseProperty("ProductCategory")]
    public virtual File? File { get; set; }

    [InverseProperty("ProductCategory")]
    public virtual ICollection<ProductFamily> ProductFamily { get; } = new List<ProductFamily>();
}
