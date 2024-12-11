using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("ThirdPartyID", "BusinessUnitID", "ThirdPartyTypeID")]
public partial class ThirdPartyBusinessUnit
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ThirdPartyID { get; set; } = null!;

    /// <summary>
    /// B.U.
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ThirdPartyTypeID { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }
}
