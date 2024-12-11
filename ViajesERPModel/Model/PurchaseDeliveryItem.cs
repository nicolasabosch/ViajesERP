using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class PurchaseDeliveryItem
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseDeliveryItemID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseDeliveryID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseOrderItemID { get; set; } = null!;

    /// <summary>
    /// Enviado
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal DeliveredQuantity { get; set; }

    /// <summary>
    /// Unidades Enviadas
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal DeliveredUnits { get; set; }

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

    [ForeignKey("PurchaseDeliveryID")]
    [InverseProperty("PurchaseDeliveryItem")]
    public virtual PurchaseDelivery PurchaseDelivery { get; set; } = null!;

    [ForeignKey("PurchaseOrderItemID")]
    [InverseProperty("PurchaseDeliveryItem")]
    public virtual PurchaseOrderItem PurchaseOrderItem { get; set; } = null!;
}
