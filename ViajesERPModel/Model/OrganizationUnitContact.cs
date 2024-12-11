using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class OrganizationUnitContact
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitContactID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitContactName { get; set; } = null!;

    /// <summary>
    /// Telefono
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string Phone { get; set; } = null!;

    /// <summary>
    /// U.O.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitID { get; set; } = null!;

    /// <summary>
    /// Email
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    /// <summary>
    /// Direccion
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CityName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DistrictName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ZipCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TaxCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DeliveryInstruction { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TransportationName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TransportationAddress { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DocumentNumber { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TransportationPhone { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? ContactSourceID { get; set; }

    [ForeignKey("ContactSourceID")]
    [InverseProperty("OrganizationUnitContact")]
    public virtual ContactSource? ContactSource { get; set; }

    [ForeignKey("OrganizationUnitID")]
    [InverseProperty("OrganizationUnitContact")]
    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;

    [InverseProperty("OrganizationUnitContact")]
    public virtual ICollection<SaleRetail> SaleRetail { get; } = new List<SaleRetail>();

    [InverseProperty("OrganizationUnitContact")]
    public virtual ICollection<SaleRetailCredit> SaleRetailCredit { get; } = new List<SaleRetailCredit>();
}
