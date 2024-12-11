using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ProductStatus
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProductStatusID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(200)]
    public string ProductStatusName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("DefaultInputProductStatus")]
    public virtual ICollection<Product> Product { get; } = new List<Product>();

    [InverseProperty("ProductStatus")]
    public virtual ICollection<PurchaseReceptionItem> PurchaseReceptionItem { get; } = new List<PurchaseReceptionItem>();
}
