using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vProductWithBOM
{
    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string ProductCode { get; set; } = null!;

    [StringLength(200)]
    public string ProductName { get; set; } = null!;
}
