using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ProductSeasonality
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProductSeasonalityID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string ProductSeasonalityName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("ProductSeasonality")]
    public virtual ICollection<ProductFamily> ProductFamily { get; } = new List<ProductFamily>();
}
