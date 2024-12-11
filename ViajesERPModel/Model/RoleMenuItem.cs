using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("RoleID", "MenuItemID")]
public partial class RoleMenuItem
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string RoleID { get; set; } = null!;

    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string MenuItemID { get; set; } = null!;

    public bool? AllowRead { get; set; }

    public bool? AllowCreate { get; set; }

    public bool? AllowEdit { get; set; }

    public bool? AllowDelete { get; set; }

    public bool? AllowFinish { get; set; }

    public bool? AllowVoid { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("MenuItemID")]
    [InverseProperty("RoleMenuItem")]
    public virtual MenuItem MenuItem { get; set; } = null!;

    [ForeignKey("RoleID")]
    [InverseProperty("RoleMenuItem")]
    public virtual Role Role { get; set; } = null!;
}
