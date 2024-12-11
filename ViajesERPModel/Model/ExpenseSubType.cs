using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ExpenseSubType
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ExpenseSubTypeID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string ExpenseSubTypeName { get; set; } = null!;

    /// <summary>
    /// Tipo Gasto
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ExpenseTypeID { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("ExpenseTypeID")]
    [InverseProperty("ExpenseSubType")]
    public virtual ExpenseType ExpenseType { get; set; } = null!;

    [InverseProperty("ExpenseSubType")]
    public virtual ICollection<VendorPayment> VendorPayment { get; } = new List<VendorPayment>();
}
