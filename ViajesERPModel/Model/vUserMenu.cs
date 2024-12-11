using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vUserMenu
{
    [StringLength(36)]
    [Unicode(false)]
    public string MenuBarID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;

    [StringLength(100)]
    public string MenuBarName { get; set; } = null!;

    public short MenuBarDisplayOrder { get; set; }

    [StringLength(100)]
    public string MenuItemName { get; set; } = null!;

    public short MenuItemDisplayOrder { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string ControllerName { get; set; } = null!;

    public short GroupNumber { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string RouteName { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string TemplateUrl { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string MenuItemID { get; set; } = null!;

    public bool IsPage { get; set; }

    public bool? AllowRead { get; set; }

    public bool? AllowCreate { get; set; }

    public bool? AllowEdit { get; set; }

    public bool? AllowDelete { get; set; }

    public bool? AllowFinish { get; set; }

    public bool? AllowVoid { get; set; }
}
