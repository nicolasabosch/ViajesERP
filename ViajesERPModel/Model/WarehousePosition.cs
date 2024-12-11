using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class WarehousePosition
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string WarehousePositionID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string WarehousePositionName { get; set; } = null!;

    /// <summary>
    /// Piso
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string Floor { get; set; } = null!;

    /// <summary>
    /// Pasillo
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string Aisle { get; set; } = null!;

    /// <summary>
    /// Módulo
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string Module { get; set; } = null!;

    /// <summary>
    /// Estante
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string Shelf { get; set; } = null!;

    /// <summary>
    /// Depósito
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string WarehouseID { get; set; } = null!;

    /// <summary>
    /// Activo
    /// </summary>
    public bool Active { get; set; }

    /// <summary>
    /// Para Ingreso
    /// </summary>
    public bool InputPosition { get; set; }

    /// <summary>
    /// Para Egreso
    /// </summary>
    public bool OutputPosition { get; set; }

    /// <summary>
    /// Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? CustomerID { get; set; }

    /// <summary>
    /// Incluida en Cuenta Stock
    /// </summary>
    public bool IncludeInCount { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("WarehousePosition")]
    public virtual ICollection<CreditNoteItem> CreditNoteItem { get; } = new List<CreditNoteItem>();

    [InverseProperty("WarehousePosition")]
    public virtual ICollection<Inventory> Inventory { get; } = new List<Inventory>();

    [InverseProperty("WarehousePosition")]
    public virtual ICollection<PurchaseReceptionItem> PurchaseReceptionItem { get; } = new List<PurchaseReceptionItem>();

    [InverseProperty("WarehousePosition")]
    public virtual ICollection<SaleDelivery> SaleDelivery { get; } = new List<SaleDelivery>();

    [ForeignKey("WarehouseID")]
    [InverseProperty("WarehousePosition")]
    public virtual Warehouse Warehouse { get; set; } = null!;
}
