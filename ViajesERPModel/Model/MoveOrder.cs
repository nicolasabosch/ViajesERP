using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class MoveOrder
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string MoveOrderID { get; set; } = null!;

    /// <summary>
    /// Número
    /// </summary>
    public int MoveOrderNumber { get; set; }

    /// <summary>
    /// Fecha
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime MoveOrderDate { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string MoveOrderStatusID { get; set; } = null!;

    /// <summary>
    /// Sucursal
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SourceOrganizationUnitID { get; set; } = null!;

    /// <summary>
    /// Contacto
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? DestinationOrganizationUnitID { get; set; }

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

    [Column(TypeName = "date")]
    public DateTime? DeliveryDate { get; set; }

    [InverseProperty("MoveOrder")]
    public virtual ICollection<MoveOrderItem> MoveOrderItem { get; } = new List<MoveOrderItem>();

    [ForeignKey("MoveOrderStatusID")]
    [InverseProperty("MoveOrder")]
    public virtual MoveOrderStatus MoveOrderStatus { get; set; } = null!;
}
