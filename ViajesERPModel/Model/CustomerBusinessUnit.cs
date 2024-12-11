using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("CustomerID", "BusinessUnitID")]
public partial class CustomerBusinessUnit
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    /// <summary>
    /// B.U.
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    /// <summary>
    /// User Id
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRepresentativeID { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("CustomerBusinessUnit")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [ForeignKey("CustomerID")]
    [InverseProperty("CustomerBusinessUnit")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("SaleRepresentativeID")]
    [InverseProperty("CustomerBusinessUnit")]
    public virtual User SaleRepresentative { get; set; } = null!;
}
