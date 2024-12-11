using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class MoveOrderItem
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string MoveOrderItemID { get; set; } = null!;

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string MoveOrderID { get; set; } = null!;

    /// <summary>
    /// Etiqueta
    /// </summary>
    public int InventoryBarCodeID { get; set; }

    /// <summary>
    /// Cantidad
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Quantity { get; set; }

    /// <summary>
    /// Comentarios
    /// </summary>
    [StringLength(2000)]
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

    [ForeignKey("MoveOrderID")]
    [InverseProperty("MoveOrderItem")]
    public virtual MoveOrder MoveOrder { get; set; } = null!;
}
