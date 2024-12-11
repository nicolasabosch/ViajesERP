using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class PurchaseReception
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseReceptionID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string PurchaseReceptionName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string WarehouseID { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime ReceptionDate { get; set; }

    /// <summary>
    /// Nro Contenedor
    /// </summary>
    public int PurchaseReceptionNumber { get; set; }

    /// <summary>
    /// Orden de Compra
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseOrderID { get; set; } = null!;

    /// <summary>
    /// Envío
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? PurchaseDeliveryID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseReceptionStatusID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? ManufacturerID { get; set; }

    /// <summary>
    /// Comentarios
    /// </summary>
    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Despacho de Aduana
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? CustomDeliveryCode { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? LabelTypeID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("LabelTypeID")]
    [InverseProperty("PurchaseReception")]
    public virtual LabelType? LabelType { get; set; }

    [ForeignKey("ManufacturerID")]
    [InverseProperty("PurchaseReception")]
    public virtual Manufacturer? Manufacturer { get; set; }

    [ForeignKey("PurchaseDeliveryID")]
    [InverseProperty("PurchaseReception")]
    public virtual PurchaseDelivery? PurchaseDelivery { get; set; }

    [InverseProperty("PurchaseReception")]
    public virtual ICollection<PurchaseInvoicePurchaseReception> PurchaseInvoicePurchaseReception { get; } = new List<PurchaseInvoicePurchaseReception>();

    [ForeignKey("PurchaseOrderID")]
    [InverseProperty("PurchaseReception")]
    public virtual PurchaseOrder PurchaseOrder { get; set; } = null!;

    [InverseProperty("PurchaseReception")]
    public virtual ICollection<PurchaseReceptionItem> PurchaseReceptionItem { get; } = new List<PurchaseReceptionItem>();

    [ForeignKey("PurchaseReceptionStatusID")]
    [InverseProperty("PurchaseReception")]
    public virtual PurchaseReceptionStatus PurchaseReceptionStatus { get; set; } = null!;

    [ForeignKey("WarehouseID")]
    [InverseProperty("PurchaseReception")]
    public virtual Warehouse Warehouse { get; set; } = null!;
}
