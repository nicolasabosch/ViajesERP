using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vProductGroup
{
    [StringLength(36)]
    [Unicode(false)]
    public string ProductGroupID { get; set; } = null!;

    [StringLength(201)]
    public string ProductGroupName { get; set; } = null!;
}
