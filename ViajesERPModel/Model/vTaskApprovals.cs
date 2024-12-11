using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vTaskApprovals
{
    public bool? Pending { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string TableKey { get; set; } = null!;

    public int TableNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? TaskCreatedDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime TaskRequiredDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;

    [StringLength(201)]
    public string UserFullName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    public int CustomerNumber { get; set; }

    [StringLength(201)]
    public string SaleRepresentativeName { get; set; } = null!;
}
