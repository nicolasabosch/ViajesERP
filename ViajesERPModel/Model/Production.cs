using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Production
{
    [Key]
    public int ProductionID { get; set; }

    [Column(TypeName = "date")]
    public DateTime ProductionDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string ProductionStatusID { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    public int ProductionUnits { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string WarehouseID { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("ProductID")]
    [InverseProperty("Production")]
    public virtual Product Product { get; set; } = null!;

    [ForeignKey("ProductionStatusID")]
    [InverseProperty("Production")]
    public virtual ProductionStatus ProductionStatus { get; set; } = null!;

    [ForeignKey("WarehouseID")]
    [InverseProperty("Production")]
    public virtual Warehouse Warehouse { get; set; } = null!;
}
