using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class SaleRetailCredit
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRetailCreditID { get; set; } = null!;

    public int SaleRetailCreditNumber { get; set; }

    /// <summary>
    /// Venta Origen
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SourceSaleRetailID { get; set; }

    /// <summary>
    /// Sucursal
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitID { get; set; } = null!;

    /// <summary>
    /// Contacto
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitContactID { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime SaleRetailCreditDate { get; set; }

    /// <summary>
    /// Moneda
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    /// <summary>
    /// Monto
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Saldo
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal OpenAmount { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("CurrencyID")]
    [InverseProperty("SaleRetailCredit")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("OrganizationUnitID")]
    [InverseProperty("SaleRetailCredit")]
    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;

    [ForeignKey("OrganizationUnitContactID")]
    [InverseProperty("SaleRetailCredit")]
    public virtual OrganizationUnitContact OrganizationUnitContact { get; set; } = null!;

    [InverseProperty("SaleRetailCredit")]
    public virtual ICollection<SaleRetailValue> SaleRetailValue { get; } = new List<SaleRetailValue>();
}
