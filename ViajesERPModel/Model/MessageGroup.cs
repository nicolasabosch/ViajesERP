using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class MessageGroup
{
    [Key]
    public int MessageGroupID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string MessageGroupName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    public bool active { get; set; }

    [InverseProperty("MessageGroup")]
    public virtual ICollection<Message> Message { get; } = new List<Message>();

    [InverseProperty("MessageGroup")]
    public virtual ICollection<MessageGroupUser> MessageGroupUser { get; } = new List<MessageGroupUser>();
}
