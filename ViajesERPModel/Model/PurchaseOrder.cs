using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class PurchaseOrder
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseOrderID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? PurchaseOrderName { get; set; }

    /// <summary>
    /// Orden de Compra
    /// </summary>
    public int PurchaseOrderNumber { get; set; }

    /// <summary>
    /// Estado
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseOrderStatusID { get; set; } = null!;

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    /// <summary>
    /// Fecha
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime RequestedDate { get; set; }

    /// <summary>
    /// Fecha
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? ArrivalDate { get; set; }

    /// <summary>
    /// Moneda
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Proveedor
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string VendorID { get; set; } = null!;

    /// <summary>
    /// Temporada
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SeasonID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? ManufacturerID { get; set; }

    /// <summary>
    /// Comentarios
    /// </summary>
    [Unicode(false)]
    public string? Remarks { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("PurchaseOrder")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [ForeignKey("CurrencyID")]
    [InverseProperty("PurchaseOrder")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("ManufacturerID")]
    [InverseProperty("PurchaseOrder")]
    public virtual Manufacturer? Manufacturer { get; set; }

    [InverseProperty("PurchaseOrder")]
    public virtual ICollection<PurchaseDelivery> PurchaseDelivery { get; } = new List<PurchaseDelivery>();

    [InverseProperty("PurchaseOrder")]
    public virtual ICollection<PurchaseOrderItem> PurchaseOrderItem { get; } = new List<PurchaseOrderItem>();

    [ForeignKey("PurchaseOrderStatusID")]
    [InverseProperty("PurchaseOrder")]
    public virtual PurchaseOrderStatus PurchaseOrderStatus { get; set; } = null!;

    [InverseProperty("PurchaseOrder")]
    public virtual ICollection<PurchaseReception> PurchaseReception { get; } = new List<PurchaseReception>();

    [ForeignKey("SeasonID")]
    [InverseProperty("PurchaseOrder")]
    public virtual Season Season { get; set; } = null!;

    [ForeignKey("VendorID")]
    [InverseProperty("PurchaseOrder")]
    public virtual Vendor Vendor { get; set; } = null!;
}
