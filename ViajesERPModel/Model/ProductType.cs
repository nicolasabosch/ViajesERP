using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ProductType
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProductTypeID { get; set; } = null!;

    [StringLength(200)]
    public string ProductTypeName { get; set; } = null!;

    public bool? UsesLabelCode { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("ProductType")]
    public virtual ICollection<ProductFamily> ProductFamily { get; } = new List<ProductFamily>();
}
