using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class PurchaseDeliveryDetail
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseDeliveryDetailID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseDeliveryID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ProductDescription { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? ProductFamilyName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string UnitOfMeasureID { get; set; } = null!;

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
    /// % Derechos
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal RightsPercent { get; set; }

    /// <summary>
    /// % Estadísticas
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal StatisticsPercent { get; set; }

    /// <summary>
    /// Precio FOB Unitario
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal UnitFOBPrice { get; set; }

    /// <summary>
    /// AlicuotaIVA
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AlicuotaIVA { get; set; }

    /// <summary>
    /// AlicuotaIVAAdicional
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AlicuotaIVAAdicional { get; set; }

    /// <summary>
    /// AlicuotaGanancias
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AlicuotaGanancias { get; set; }

    /// <summary>
    /// Precio Venta Contable
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? UnitPriceContable { get; set; }

    /// <summary>
    /// Fórmula
    /// </summary>
    [StringLength(5000)]
    [Unicode(false)]
    public string? Formula { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? RealUnitOfMeasureID { get; set; }

    /// <summary>
    /// Cantidad Real
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? RealDeliveredQuantity { get; set; }

    /// <summary>
    /// Unidades Real
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? RealDeliveredUnits { get; set; }

    /// <summary>
    /// Precio FOB Unitario Real
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RealUnitFOBPrice { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("PurchaseDeliveryID")]
    [InverseProperty("PurchaseDeliveryDetail")]
    public virtual PurchaseDelivery PurchaseDelivery { get; set; } = null!;

    [ForeignKey("UnitOfMeasureID")]
    [InverseProperty("PurchaseDeliveryDetail")]
    public virtual UnitOfMeasure UnitOfMeasure { get; set; } = null!;
}
