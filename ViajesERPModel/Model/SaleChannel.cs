using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class SaleChannel
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleChannelID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string SaleChannelName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("SaleChannel")]
    public virtual ICollection<User> User { get; } = new List<User>();
}
