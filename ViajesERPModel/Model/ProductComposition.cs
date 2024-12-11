using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ProductComposition
{
    [Key]
    [StringLength(500)]
    [Unicode(false)]
    public string ProductCompositionID { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string ProductCompositionName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("ProductComposition")]
    public virtual ICollection<ProductFamily> ProductFamily { get; } = new List<ProductFamily>();
}
