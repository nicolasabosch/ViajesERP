using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class InventoryBarCode
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    public int InventoryBarCodeID { get; set; }

    /// <summary>
    /// Documento
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentID { get; set; } = null!;

    /// <summary>
    /// Tipo Documento
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentTypeID { get; set; } = null!;

    /// <summary>
    /// Producto
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    /// <summary>
    /// OU
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? OrganizationUnitID { get; set; }

    /// <summary>
    /// Etiqueta
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? LabelCode { get; set; }

    /// <summary>
    /// Cantidad
    /// </summary>
    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Estado
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? InventoryBarCodeStatusID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? BusinessUnitID { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [ForeignKey("InventoryBarCodeStatusID")]
    [InverseProperty("InventoryBarCode")]
    public virtual InventoryBarCodeStatus? InventoryBarCodeStatus { get; set; }

    [ForeignKey("ProductID")]
    [InverseProperty("InventoryBarCode")]
    public virtual Product Product { get; set; } = null!;

    [InverseProperty("InventoryBarCode")]
    public virtual ICollection<SaleRetailItem> SaleRetailItem { get; } = new List<SaleRetailItem>();
}
