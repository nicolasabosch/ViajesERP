using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class PriceList
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PriceListID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string PriceListName { get; set; } = null!;

    /// <summary>
    /// Activo
    /// </summary>
    public bool Active { get; set; }

    /// <summary>
    /// B.U.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? BusinessUnitID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("PriceList")]
    public virtual ICollection<Customer> Customer { get; } = new List<Customer>();

    [InverseProperty("PriceList")]
    public virtual ICollection<PriceListProduct> PriceListProduct { get; } = new List<PriceListProduct>();

    [InverseProperty("PriceList")]
    public virtual ICollection<PriceListProductFamily> PriceListProductFamily { get; } = new List<PriceListProductFamily>();

    [InverseProperty("PriceList")]
    public virtual ICollection<SaleOrder> SaleOrder { get; } = new List<SaleOrder>();

    [InverseProperty("PriceList")]
    public virtual ICollection<TransferOrder> TransferOrder { get; } = new List<TransferOrder>();
}
