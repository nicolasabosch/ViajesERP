using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class PurchaseReceptionItem
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseReceptionItemID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseReceptionID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseOrderItemID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? PurchaseDeliveryItemID { get; set; }

    /// <summary>
    /// Enviado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal ReceivedQuantity { get; set; }

    /// <summary>
    /// Unidades Enviadas
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal ReceivedUnits { get; set; }

    /// <summary>
    /// Posición
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? WarehousePositionID { get; set; }

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

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ProductStatusID { get; set; }

    /// <summary>
    /// Comentarios
    /// </summary>
    [Unicode(false)]
    public string? Remarks { get; set; }

    /// <summary>
    /// ABierto
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal OpenQuantity { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("ProductStatusID")]
    [InverseProperty("PurchaseReceptionItem")]
    public virtual ProductStatus? ProductStatus { get; set; }

    [ForeignKey("PurchaseReceptionID")]
    [InverseProperty("PurchaseReceptionItem")]
    public virtual PurchaseReception PurchaseReception { get; set; } = null!;

    [ForeignKey("WarehousePositionID")]
    [InverseProperty("PurchaseReceptionItem")]
    public virtual WarehousePosition? WarehousePosition { get; set; }
}
