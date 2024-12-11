using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class CountOrderItem
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CountOrderItemID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string CountOrderID { get; set; } = null!;

    public int CountOrderItemNumber { get; set; }

    /// <summary>
    /// Producto
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ProductID { get; set; }

    /// <summary>
    /// Unidades Foto
    /// </summary>
    public int ActualUnits { get; set; }

    /// <summary>
    /// mts / kilos foto
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Actual { get; set; }

    /// <summary>
    /// Cantidad contada
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Counted { get; set; }

    /// <summary>
    /// Unidades Contadas
    /// </summary>
    public int? CountedUnits { get; set; }

    /// <summary>
    /// Unidades en Stock al momento de Grabar
    /// </summary>
    public int? AvailableUnits { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("CountOrderID")]
    [InverseProperty("CountOrderItem")]
    public virtual CountOrder CountOrder { get; set; } = null!;

    [ForeignKey("ProductID")]
    [InverseProperty("CountOrderItem")]
    public virtual Product? Product { get; set; }
}
