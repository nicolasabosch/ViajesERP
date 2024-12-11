using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class LabelType
{
    /// <summary>
    /// Canal
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string LabelTypeID { get; set; } = null!;

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string LabelTypeName { get; set; } = null!;

    /// <summary>
    /// Activo
    /// </summary>
    public bool Active { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("LabelType")]
    public virtual ICollection<ProductFamilyCustomDeliveryCode> ProductFamilyCustomDeliveryCode { get; } = new List<ProductFamilyCustomDeliveryCode>();

    [InverseProperty("LabelType")]
    public virtual ICollection<PurchaseReception> PurchaseReception { get; } = new List<PurchaseReception>();
}
