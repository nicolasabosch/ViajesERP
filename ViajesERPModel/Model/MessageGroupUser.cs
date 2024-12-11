using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("MessageGroupID", "UserID")]
public partial class MessageGroupUser
{
    [Key]
    public int MessageGroupID { get; set; }

    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string MemberTypeID { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("MemberTypeID")]
    [InverseProperty("MessageGroupUser")]
    public virtual MemberType MemberType { get; set; } = null!;

    [ForeignKey("MessageGroupID")]
    [InverseProperty("MessageGroupUser")]
    public virtual MessageGroup MessageGroup { get; set; } = null!;

    [ForeignKey("UserID")]
    [InverseProperty("MessageGroupUser")]
    public virtual User User { get; set; } = null!;
}
