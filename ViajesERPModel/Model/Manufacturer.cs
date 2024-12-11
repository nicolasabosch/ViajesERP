using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Manufacturer
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ManufacturerID { get; set; } = null!;

    [StringLength(200)]
    public string ManufacturerName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("Manufacturer")]
    public virtual ICollection<ProductBrand> ProductBrand { get; } = new List<ProductBrand>();

    [InverseProperty("Manufacturer")]
    public virtual ICollection<PurchaseOrder> PurchaseOrder { get; } = new List<PurchaseOrder>();

    [InverseProperty("Manufacturer")]
    public virtual ICollection<PurchaseReception> PurchaseReception { get; } = new List<PurchaseReception>();
}
