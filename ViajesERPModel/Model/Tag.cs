using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Tag
{
    /// <summary>
    /// User Id
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string TagID { get; set; } = null!;

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string TagName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("Tag")]
    public virtual ICollection<ProductTag> ProductTag { get; } = new List<ProductTag>();
}
