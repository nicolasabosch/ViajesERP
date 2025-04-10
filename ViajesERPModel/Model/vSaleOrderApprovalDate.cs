﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vSaleOrderApprovalDate
{
    [StringLength(250)]
    [Unicode(false)]
    public string SaleOrderID { get; set; } = null!;

    public int SaleOrderNumber { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ApprovalDate { get; set; }
}
