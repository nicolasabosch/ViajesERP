using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class PickingOrder
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PickingOrderID { get; set; } = null!;

    public int PickingOrderNumber { get; set; }

    [Column(TypeName = "date")]
    public DateTime PickingOrderDate { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string PickingStatusID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string SaleOrderID { get; set; } = null!;

    /// <summary>
    /// Dock de carga
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string WarehouseID { get; set; } = null!;

    /// <summary>
    /// Comentarios
    /// </summary>
    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedOn { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("PickingOrder")]
    public virtual ICollection<PickingOrderItem> PickingOrderItem { get; } = new List<PickingOrderItem>();

    [ForeignKey("PickingStatusID")]
    [InverseProperty("PickingOrder")]
    public virtual PickingStatus PickingStatus { get; set; } = null!;

    [ForeignKey("SaleOrderID")]
    [InverseProperty("PickingOrder")]
    public virtual SaleOrder SaleOrder { get; set; } = null!;

    [ForeignKey("WarehouseID")]
    [InverseProperty("PickingOrder")]
    public virtual Warehouse Warehouse { get; set; } = null!;
}
