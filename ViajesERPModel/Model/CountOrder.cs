using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class CountOrder
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CountOrderID { get; set; } = null!;

    /// <summary>
    /// Número
    /// </summary>
    public int CountOrderNumber { get; set; }

    /// <summary>
    /// Estado
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CountOrderStatusID { get; set; } = null!;

    /// <summary>
    /// Fecha
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime RequestedDate { get; set; }

    /// <summary>
    /// Deposito
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string WarehouseID { get; set; } = null!;

    /// <summary>
    /// Asignado A
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string AssginedName { get; set; } = null!;

    /// <summary>
    /// Familia
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ProductFamilyID { get; set; } = null!;

    /// <summary>
    /// B.U.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

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
    [InverseProperty("CountOrder")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [InverseProperty("CountOrder")]
    public virtual ICollection<CountOrderItem> CountOrderItem { get; } = new List<CountOrderItem>();

    [ForeignKey("CountOrderStatusID")]
    [InverseProperty("CountOrder")]
    public virtual CountOrderStatus CountOrderStatus { get; set; } = null!;

    [ForeignKey("ProductFamilyID")]
    [InverseProperty("CountOrder")]
    public virtual ProductFamily ProductFamily { get; set; } = null!;

    [ForeignKey("WarehouseID")]
    [InverseProperty("CountOrder")]
    public virtual Warehouse Warehouse { get; set; } = null!;
}
