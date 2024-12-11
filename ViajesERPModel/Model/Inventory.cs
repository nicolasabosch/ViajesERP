using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Index("BusinessUnitID", Name = "IX_Inventory_BusinessUnitID")]
[Index("ProductID", Name = "IX_Inventory_ProductID")]
[Index("WarehouseID", Name = "IX_Inventory_WarehouseID")]
public partial class Inventory
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string InventoryID { get; set; } = null!;

    public int InventoryNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? WarehouseID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? WarehousePositionID { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    /// <summary>
    /// Lote
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? BatchName { get; set; }

    /// <summary>
    /// Fecha Producción
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? ProductionDate { get; set; }

    /// <summary>
    /// Fecha VTO
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? ExpirationDate { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal Available { get; set; }

    /// <summary>
    /// Picking
    /// </summary>
    [Column(TypeName = "decimal(18, 6)")]
    public decimal HardCommitted { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal Quarantined { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal NotAvailable { get; set; }

    /// <summary>
    /// Stock de seguridad
    /// </summary>
    [Column(TypeName = "decimal(18, 6)")]
    public decimal SafetyStock { get; set; }

    public int AvailableUnits { get; set; }

    /// <summary>
    /// Picking
    /// </summary>
    public int HardCommittedUnits { get; set; }

    public int QuarantinedUnits { get; set; }

    public int NotAvailableUnits { get; set; }

    /// <summary>
    /// Stock de seguridad
    /// </summary>
    public int SafetyStockUnits { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? TransitQuantity { get; set; }

    public int? TransitUnits { get; set; }

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("Inventory")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [ForeignKey("ProductID")]
    [InverseProperty("Inventory")]
    public virtual Product Product { get; set; } = null!;

    [InverseProperty("Inventory")]
    public virtual ICollection<SaleDeliveryItem> SaleDeliveryItem { get; } = new List<SaleDeliveryItem>();

    [ForeignKey("WarehouseID")]
    [InverseProperty("Inventory")]
    public virtual Warehouse? Warehouse { get; set; }

    [ForeignKey("WarehousePositionID")]
    [InverseProperty("Inventory")]
    public virtual WarehousePosition? WarehousePosition { get; set; }
}
