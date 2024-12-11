using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Parameter
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ParameterID { get; set; } = null!;

    [StringLength(200)]
    public string? ParameterName { get; set; }

    public string? ParameterValue { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }
}
