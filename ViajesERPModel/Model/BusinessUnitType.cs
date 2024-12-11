using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class BusinessUnitType
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitTypeID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string BusinessUnitTypeName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("BusinessUnitType")]
    public virtual ICollection<BusinessUnit> BusinessUnit { get; } = new List<BusinessUnit>();
}
