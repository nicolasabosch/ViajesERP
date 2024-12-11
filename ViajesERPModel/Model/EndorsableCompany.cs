using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class EndorsableCompany
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string EndorsableCompanyID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string EndorsableCompanyName { get; set; } = null!;

    /// <summary>
    /// CUIT
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? TaxCode { get; set; }

    /// <summary>
    /// Domicilio
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? Address { get; set; }

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

    [InverseProperty("EndorsableCompany")]
    public virtual ICollection<BatchPaymentValue> BatchPaymentValue { get; } = new List<BatchPaymentValue>();

    [InverseProperty("EndorsableCompany")]
    public virtual ICollection<SaleRetailValue> SaleRetailValue { get; } = new List<SaleRetailValue>();
}
