using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class Hoja
{
    [StringLength(255)]
    public string? TELA { get; set; }

    [StringLength(255)]
    public string? COMPOSICION { get; set; }
}
