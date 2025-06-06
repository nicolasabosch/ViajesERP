﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("PriceListID", "ProductFamilyID", "CurrencyID")]
public partial class PriceListProductFamily
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string PriceListID { get; set; } = null!;

    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProductFamilyID { get; set; } = null!;

    /// <summary>
    /// Moneda
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal Price { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("CurrencyID")]
    [InverseProperty("PriceListProductFamily")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("PriceListID")]
    [InverseProperty("PriceListProductFamily")]
    public virtual PriceList PriceList { get; set; } = null!;

    [ForeignKey("ProductFamilyID")]
    [InverseProperty("PriceListProductFamily")]
    public virtual ProductFamily ProductFamily { get; set; } = null!;
}
