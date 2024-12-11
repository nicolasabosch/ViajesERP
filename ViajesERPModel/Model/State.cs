using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class State
{
    /// <summary>
    /// Código ISO 3166-2
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string StateID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(200)]
    public string StateName { get; set; } = null!;

    /// <summary>
    /// País
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CountryID { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("CountryID")]
    [InverseProperty("State")]
    public virtual Country Country { get; set; } = null!;

    [InverseProperty("State")]
    public virtual ICollection<Customer> Customer { get; } = new List<Customer>();

    [InverseProperty("State")]
    public virtual ICollection<CustomerDeliveryAddress> CustomerDeliveryAddress { get; } = new List<CustomerDeliveryAddress>();

    [InverseProperty("State")]
    public virtual ICollection<WithdrawalOrder> WithdrawalOrder { get; } = new List<WithdrawalOrder>();
}
