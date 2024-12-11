using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("MessageID", "UserID")]
public partial class MessageUser
{
    [Key]
    public int MessageID { get; set; }

    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string MessageCategoryID { get; set; } = null!;

    public DateTimeOffset? ReadOn { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("MessageCategoryID")]
    [InverseProperty("MessageUser")]
    public virtual MessageCategory MessageCategory { get; set; } = null!;

    [ForeignKey("UserID")]
    [InverseProperty("MessageUser")]
    public virtual User User { get; set; } = null!;
}
