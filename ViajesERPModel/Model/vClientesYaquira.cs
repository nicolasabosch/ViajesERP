using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vClientesYaquira
{
    public int CustomerNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string CustomerLegalName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? FiscalCode { get; set; }
}
