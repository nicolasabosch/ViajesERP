using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("ProductFamilyID", "SaleRepresentativeID")]
public partial class CommissionProductFamily
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ProductFamilyID { get; set; } = null!;

    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRepresentativeID { get; set; } = null!;

    [Column(TypeName = "decimal(5, 2)")]
    public decimal CommisionPercent { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }
}
