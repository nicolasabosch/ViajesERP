using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vTask
{
    public long TaskID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string TableKey { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    public int TableNumber { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string TaskTypeName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string TaskStatusName { get; set; } = null!;

    [StringLength(201)]
    public string? UserFullName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? UserID { get; set; }

    [Column(TypeName = "date")]
    public DateTime? TaskCreatedDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime TaskRequiredDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleRepresentativeID { get; set; }

    [StringLength(201)]
    public string SaleRepresentativeName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string TaskStatusID { get; set; } = null!;

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

    public int Pending { get; set; }

    [Unicode(false)]
    public string? ResponseText { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }
}
