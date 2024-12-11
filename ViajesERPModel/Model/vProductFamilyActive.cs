using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vProductFamilyActive
{
    [StringLength(36)]
    [Unicode(false)]
    public string ProductTypeID { get; set; } = null!;

    [StringLength(200)]
    public string ProductTypeName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ProductFamilyID { get; set; } = null!;

    [StringLength(200)]
    public string ProductFamilyName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? ProductGroupID { get; set; }

    [StringLength(200)]
    public string? ProductGroupName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? ProductCategoryID { get; set; }

    [StringLength(200)]
    public string? ProductCategoryName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string UnitOfMeasureID { get; set; } = null!;

    [StringLength(200)]
    public string UnitOfMeasureName { get; set; } = null!;
}
