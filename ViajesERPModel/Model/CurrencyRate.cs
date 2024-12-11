using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Index("CurrencyID", "CurrencyRateDate", Name = "uq_CurrencyRate_CurrencyID_CurrencyRateDate", IsUnique = true)]
public partial class CurrencyRate
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyRateID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime CurrencyRateDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CurrencyRateAmount { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("CurrencyID")]
    [InverseProperty("CurrencyRate")]
    public virtual Currency Currency { get; set; } = null!;
}
