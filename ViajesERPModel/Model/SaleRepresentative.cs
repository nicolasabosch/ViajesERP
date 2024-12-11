using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class SaleRepresentative
{
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRepresentativeID { get; set; } = null!;

    [StringLength(201)]
    public string SaleRepresentativeName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleChannelID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SaleChannelName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }
}
