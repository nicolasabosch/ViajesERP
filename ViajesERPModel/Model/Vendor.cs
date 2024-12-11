using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Vendor
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string VendorID { get; set; } = null!;

    [StringLength(200)]
    public string VendorName { get; set; } = null!;

    /// <summary>
    /// Código Interno
    /// </summary>
    public int VendorNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CountryID { get; set; } = null!;

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string PaymentConditionID { get; set; } = null!;

    [Required]
    public bool? Active { get; set; }

    /// <summary>
    /// Dirección
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    /// <summary>
    /// Teléfono
    /// </summary>
    [StringLength(400)]
    [Unicode(false)]
    public string? Phone { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    [StringLength(400)]
    [Unicode(false)]
    public string? Email { get; set; }

    /// <summary>
    /// Contacto
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? ContactName { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("CountryID")]
    [InverseProperty("Vendor")]
    public virtual Country Country { get; set; } = null!;

    [ForeignKey("PaymentConditionID")]
    [InverseProperty("Vendor")]
    public virtual PaymentCondition PaymentCondition { get; set; } = null!;

    [InverseProperty("Vendor")]
    public virtual ICollection<PurchaseInvoice> PurchaseInvoice { get; } = new List<PurchaseInvoice>();

    [InverseProperty("Vendor")]
    public virtual ICollection<PurchaseOrder> PurchaseOrder { get; } = new List<PurchaseOrder>();
}
