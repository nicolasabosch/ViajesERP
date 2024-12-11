using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Carrier
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CarrierID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string CarrierName { get; set; } = null!;

    /// <summary>
    /// Dirección
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }

    /// <summary>
    /// Teléfono
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Phone { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("Carrier")]
    public virtual ICollection<Customer> Customer { get; } = new List<Customer>();

    [InverseProperty("Carrier")]
    public virtual ICollection<SaleOrder> SaleOrder { get; } = new List<SaleOrder>();

    [InverseProperty("Carrier")]
    public virtual ICollection<TransferOrder> TransferOrder { get; } = new List<TransferOrder>();

    [InverseProperty("Carrier")]
    public virtual ICollection<WithdrawalOrder> WithdrawalOrder { get; } = new List<WithdrawalOrder>();
}
