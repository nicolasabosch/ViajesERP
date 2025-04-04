using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class PurchaseDelivery
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseDeliveryID { get; set; } = null!;

    /// <summary>
    /// Nombre Contenedor
    /// Nombre Contenedor
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string PurchaseDeliveryName { get; set; } = null!;

    /// <summary>
    /// Descripción
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string PurchaseDeliveryDescription { get; set; } = null!;

    /// <summary>
    /// Nro Contenedor
    /// </summary>
    public int PurchaseDeliveryNumber { get; set; }

    /// <summary>
    /// Estado
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseDeliveryStatusID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Comentarios
    /// </summary>
    [Unicode(false)]
    public string? Remarks { get; set; }

    /// <summary>
    /// Orden de Compra
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseOrderID { get; set; } = null!;

    /// <summary>
    /// Fecha Embarque
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? ShipmentDate { get; set; }

    /// <summary>
    /// Fecha Arribo
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? ArrivalDate { get; set; }

    /// <summary>
    /// Fecha Entrega / Disponible
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? DeliveryDate { get; set; }

    /// <summary>
    /// DL Ref
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? ForwarderCode { get; set; }

    /// <summary>
    /// SEAL
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? SealCode { get; set; }

    /// <summary>
    /// Despacho de Aduana
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? CustomDeliveryCode { get; set; }

    [Column(TypeName = "date")]
    public DateTime? PreSalesEndDate { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("PurchaseDelivery")]
    public virtual ICollection<PurchaseDeliveryDetail> PurchaseDeliveryDetail { get; } = new List<PurchaseDeliveryDetail>();

    [InverseProperty("PurchaseDelivery")]
    public virtual ICollection<PurchaseDeliveryItem> PurchaseDeliveryItem { get; } = new List<PurchaseDeliveryItem>();

    [InverseProperty("PurchaseDelivery")]
    public virtual ICollection<PurchaseDeliverySettlement> PurchaseDeliverySettlement { get; } = new List<PurchaseDeliverySettlement>();

    [ForeignKey("PurchaseDeliveryStatusID")]
    [InverseProperty("PurchaseDelivery")]
    public virtual PurchaseDeliveryStatus PurchaseDeliveryStatus { get; set; } = null!;

    [ForeignKey("PurchaseOrderID")]
    [InverseProperty("PurchaseDelivery")]
    public virtual PurchaseOrder PurchaseOrder { get; set; } = null!;

    [InverseProperty("PurchaseDelivery")]
    public virtual ICollection<PurchaseReception> PurchaseReception { get; } = new List<PurchaseReception>();

    [InverseProperty("PurchaseDelivery")]
    public virtual ICollection<TransferOrder> TransferOrder { get; } = new List<TransferOrder>();
}
