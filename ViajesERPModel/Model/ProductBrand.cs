using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ProductBrand
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProductBrandID { get; set; } = null!;

    [StringLength(200)]
    public string ProductBrandName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ManufacturerID { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("ManufacturerID")]
    [InverseProperty("ProductBrand")]
    public virtual Manufacturer Manufacturer { get; set; } = null!;

    [InverseProperty("ProductBrand")]
    public virtual ICollection<Product> Product { get; } = new List<Product>();
}
