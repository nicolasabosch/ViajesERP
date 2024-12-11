using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class MenuBar
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string MenuBarID { get; set; } = null!;

    [StringLength(100)]
    public string MenuBarName { get; set; } = null!;

    public short DisplayOrder { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("MenuBar")]
    public virtual ICollection<MenuItem> MenuItem { get; } = new List<MenuItem>();
}
