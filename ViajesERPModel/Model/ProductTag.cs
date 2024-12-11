using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("ProductID", "TagID")]
public partial class ProductTag
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    /// <summary>
    /// User Id
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string TagID { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("ProductID")]
    [InverseProperty("ProductTag")]
    public virtual Product Product { get; set; } = null!;

    [ForeignKey("TagID")]
    [InverseProperty("ProductTag")]
    public virtual Tag Tag { get; set; } = null!;
}
