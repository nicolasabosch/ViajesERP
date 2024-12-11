using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vReceipt
{
    [StringLength(36)]
    [Unicode(false)]
    public string ReceiptiD { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    public int ReceiptNumber { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? AppliedAmount { get; set; }
}
