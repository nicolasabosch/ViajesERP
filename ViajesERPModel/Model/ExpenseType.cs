using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ExpenseType
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ExpenseTypeID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string ExpenseTypeName { get; set; } = null!;

    /// <summary>
    /// B.U.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    /// <summary>
    /// Tipo
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string DebitCredit { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("ExpenseType")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [InverseProperty("ExpenseType")]
    public virtual ICollection<ExpenseSubType> ExpenseSubType { get; } = new List<ExpenseSubType>();

    [InverseProperty("ExpenseType")]
    public virtual ICollection<VendorPayment> VendorPayment { get; } = new List<VendorPayment>();
}
