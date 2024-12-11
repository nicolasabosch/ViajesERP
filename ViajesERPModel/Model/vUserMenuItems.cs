using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vUserMenuItems
{
    [StringLength(100)]
    public string MenuBarName { get; set; } = null!;

    [StringLength(100)]
    public string MenuItemName { get; set; } = null!;

    [StringLength(100)]
    public string RoleName { get; set; } = null!;

    [StringLength(201)]
    public string FullName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string LogonName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleChannelID { get; set; }
}
