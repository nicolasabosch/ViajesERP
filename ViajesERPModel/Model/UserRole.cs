using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("UserID", "RoleID")]
public partial class UserRole
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;

    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string RoleID { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("RoleID")]
    [InverseProperty("UserRole")]
    public virtual Role Role { get; set; } = null!;

    [ForeignKey("UserID")]
    [InverseProperty("UserRole")]
    public virtual User User { get; set; } = null!;
}
