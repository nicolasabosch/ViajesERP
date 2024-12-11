using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class CustomerDeliveryAddress
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CustomerDeliveryAddressID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    /// <summary>
    /// Razón Social
    /// </summary>
    [StringLength(300)]
    [Unicode(false)]
    public string CustomerLegalName { get; set; } = null!;

    /// <summary>
    /// Provincia
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string StateID { get; set; } = null!;

    /// <summary>
    /// Dirección
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string Address { get; set; } = null!;

    /// <summary>
    /// Localidad
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? DistrictName { get; set; }

    /// <summary>
    /// Código Postal
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? ZipCode { get; set; }

    /// <summary>
    /// Teléfono
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Phone { get; set; }

    /// <summary>
    /// Condición IVA
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? FiscalCodeTypeID { get; set; }

    /// <summary>
    /// CUIT
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? FiscalCode { get; set; }

    /// <summary>
    /// IIBB
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? TaxCode { get; set; }

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
    public string? DeliveryZoneID { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DeliveryInstruction { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? CarrierID { get; set; }

    [ForeignKey("CustomerID")]
    [InverseProperty("CustomerDeliveryAddress")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("DeliveryZoneID")]
    [InverseProperty("CustomerDeliveryAddress")]
    public virtual DeliveryZone? DeliveryZone { get; set; }

    [ForeignKey("FiscalCodeTypeID")]
    [InverseProperty("CustomerDeliveryAddress")]
    public virtual FiscalCodeType? FiscalCodeType { get; set; }

    [ForeignKey("StateID")]
    [InverseProperty("CustomerDeliveryAddress")]
    public virtual State State { get; set; } = null!;
}
