using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vSaleOrderTask
{
    public long TaskID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string SaleOrderID { get; set; } = null!;

    public int SaleOrderNumber { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string TaskTypeName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string TaskStatusName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleRepresentativeID { get; set; }

    [StringLength(201)]
    public string SaleRepresentativeName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string TaskStatusID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string TaskClassID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string TaskClassName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? TeamName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? TeamID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string TaskTypeID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    public int CustomerNumber { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    [Unicode(false)]
    public string? ResponseText { get; set; }

    public DateTimeOffset? AvailableOn { get; set; }

    public DateTimeOffset? FinishedOn { get; set; }

    [StringLength(202)]
    public string? FinishedBy { get; set; }
}
