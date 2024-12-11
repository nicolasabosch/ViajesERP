﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Role
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string RoleID { get; set; } = null!;

    /// <summary>
    /// Rol
    /// </summary>
    [StringLength(100)]
    public string RoleName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("Role")]
    public virtual ICollection<RoleMenuItem> RoleMenuItem { get; } = new List<RoleMenuItem>();

    [InverseProperty("Role")]
    public virtual ICollection<UserRole> UserRole { get; } = new List<UserRole>();
}
