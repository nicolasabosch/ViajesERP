using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class PurchaseDeliverySettlement
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseDeliverySettlementID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseDeliveryID { get; set; } = null!;

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ConceptID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string ConceptCode { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string ConceptName { get; set; } = null!;

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ConceptGroupID { get; set; } = null!;

    /// <summary>
    /// Fórmula
    /// </summary>
    [StringLength(5000)]
    [Unicode(false)]
    public string? Formula { get; set; }

    /// <summary>
    /// Activo
    /// </summary>
    public bool Active { get; set; }

    public int DisplayOrder { get; set; }

    /// <summary>
    /// BaseCostoReal
    /// </summary>
    [Column(TypeName = "decimal(10, 2)")]
    public decimal BaseCostoReal { get; set; }

    /// <summary>
    /// BaseCostoContable
    /// </summary>
    [Column(TypeName = "decimal(10, 2)")]
    public decimal BaseCostoContable { get; set; }

    /// <summary>
    /// Alicuota IVA
    /// </summary>
    [Column(TypeName = "decimal(10, 2)")]
    public decimal AlicuotaIVA { get; set; }

    /// <summary>
    /// Percepción IIBB CABA
    /// </summary>
    [Column(TypeName = "decimal(10, 2)")]
    public decimal PercepcionIIBBCABA { get; set; }

    /// <summary>
    /// Percepción IIBB ARBA
    /// </summary>
    [Column(TypeName = "decimal(10, 2)")]
    public decimal PercepcionIIBBARBA { get; set; }

    /// <summary>
    /// Percepcion IVA
    /// </summary>
    [Column(TypeName = "decimal(10, 2)")]
    public decimal PercepcionIVA { get; set; }

    /// <summary>
    /// Retencion Ganancias
    /// </summary>
    [Column(TypeName = "decimal(10, 2)")]
    public decimal RetencionGanancias { get; set; }

    /// <summary>
    /// InputOutput
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string InputOutput { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Amount { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("PurchaseDeliveryID")]
    [InverseProperty("PurchaseDeliverySettlement")]
    public virtual PurchaseDelivery PurchaseDelivery { get; set; } = null!;
}
