using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class MenuItem
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string MenuItemID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    public string MenuItemName { get; set; } = null!;

    /// <summary>
    /// Menu
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string MenuBarID { get; set; } = null!;

    /// <summary>
    /// Orden
    /// </summary>
    public short DisplayOrder { get; set; }

    public short GroupNumber { get; set; }

    /// <summary>
    /// TemplateUrl
    /// </summary>
    [StringLength(250)]
    [Unicode(false)]
    public string TemplateUrl { get; set; } = null!;

    /// <summary>
    /// RouteName
    /// </summary>
    [StringLength(250)]
    [Unicode(false)]
    public string RouteName { get; set; } = null!;

    /// <summary>
    /// ControllerName
    /// </summary>
    [StringLength(250)]
    [Unicode(false)]
    public string ControllerName { get; set; } = null!;

    /// <summary>
    /// Es Página
    /// </summary>
    public bool IsPage { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("MenuBarID")]
    [InverseProperty("MenuItem")]
    public virtual MenuBar MenuBar { get; set; } = null!;

    [InverseProperty("MenuItem")]
    public virtual ICollection<RoleMenuItem> RoleMenuItem { get; } = new List<RoleMenuItem>();

    [InverseProperty("MenuItem")]
    public virtual ICollection<UserMenuItem> UserMenuItem { get; } = new List<UserMenuItem>();
}
