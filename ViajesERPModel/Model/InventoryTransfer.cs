using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class InventoryTransfer
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string InventoryTransferID { get; set; } = null!;

    /// <summary>
    /// Descripción
    /// </summary>
    [MaxLength(500)]
    public byte[]? InventoyTransferName { get; set; }

    /// <summary>
    /// Número
    /// </summary>
    public int InventoryTransferNumber { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string InventoryTransferTypeID { get; set; } = null!;

    /// <summary>
    /// Producto
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    /// <summary>
    /// Posición Origen
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SourceWarehousePositionID { get; set; }

    /// <summary>
    /// Estado Origen
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SourceInventoryStatus { get; set; }

    /// <summary>
    /// B.U. Origen
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SourceBusinessUnitID { get; set; }

    /// <summary>
    /// Posición Destino
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? DestinationWarehousePositionID { get; set; }

    /// <summary>
    /// Estado Destino
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? DestinationInventoryStatus { get; set; }

    /// <summary>
    /// B.U. Destino
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? DestinationBusinessUnitID { get; set; }

    /// <summary>
    /// Cantidad
    /// </summary>
    [Column(TypeName = "decimal(18, 6)")]
    public decimal Quantity { get; set; }

    /// <summary>
    /// Bultos
    /// </summary>
    public int Units { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [Column(TypeName = "date")]
    public DateTime? InventoryTransferDate { get; set; }

    [ForeignKey("InventoryTransferTypeID")]
    [InverseProperty("InventoryTransfer")]
    public virtual InventoryTransferType InventoryTransferType { get; set; } = null!;

    [ForeignKey("ProductID")]
    [InverseProperty("InventoryTransfer")]
    public virtual Product Product { get; set; } = null!;
}
