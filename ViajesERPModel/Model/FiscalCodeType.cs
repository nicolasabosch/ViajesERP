using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class FiscalCodeType
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string FiscalCodeTypeID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(200)]
    public string FiscalCodeTypeName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("FiscalCodeType")]
    public virtual ICollection<Customer> Customer { get; } = new List<Customer>();

    [InverseProperty("FiscalCodeType")]
    public virtual ICollection<CustomerDeliveryAddress> CustomerDeliveryAddress { get; } = new List<CustomerDeliveryAddress>();

    [InverseProperty("FiscalCodeType")]
    public virtual ICollection<WithdrawalOrder> WithdrawalOrder { get; } = new List<WithdrawalOrder>();
}
