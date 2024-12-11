using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("UserID", "MenuItemID")]
public partial class UserMenuItem
{
    /// <summary>
    /// User Id
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;

    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string MenuItemID { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("MenuItemID")]
    [InverseProperty("UserMenuItem")]
    public virtual MenuItem MenuItem { get; set; } = null!;

    [ForeignKey("UserID")]
    [InverseProperty("UserMenuItem")]
    public virtual User User { get; set; } = null!;
}
