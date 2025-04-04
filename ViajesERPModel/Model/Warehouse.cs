using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Index("WarehouseName", Name = "IX_Warehouse_WarehouseName")]
public partial class Warehouse
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string WarehouseID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string WarehouseName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? DefaultInputWarehousePositionID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? DefaultOutputWarehousePositionID { get; set; }

    public bool UsesLabelCode { get; set; }

    public bool Active { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? WarehouseGroupID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("Warehouse")]
    public virtual ICollection<CountOrder> CountOrder { get; } = new List<CountOrder>();

    [InverseProperty("Warehouse")]
    public virtual ICollection<Inventory> Inventory { get; } = new List<Inventory>();

    [InverseProperty("Warehouse")]
    public virtual ICollection<PickingOrder> PickingOrder { get; } = new List<PickingOrder>();

    [InverseProperty("Warehouse")]
    public virtual ICollection<Production> Production { get; } = new List<Production>();

    [InverseProperty("Warehouse")]
    public virtual ICollection<PurchaseReception> PurchaseReception { get; } = new List<PurchaseReception>();

    [InverseProperty("Warehouse")]
    public virtual ICollection<SaleDeliveryNote> SaleDeliveryNote { get; } = new List<SaleDeliveryNote>();

    [InverseProperty("Warehouse")]
    public virtual ICollection<WarehousePosition> WarehousePosition { get; } = new List<WarehousePosition>();

    [InverseProperty("Warehouse")]
    public virtual ICollection<WithdrawalOrder> WithdrawalOrder { get; } = new List<WithdrawalOrder>();
}
