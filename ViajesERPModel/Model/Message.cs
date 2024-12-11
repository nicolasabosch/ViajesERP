using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Message
{
    [Key]
    public int MessageID { get; set; }

    public int MessageGroupID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string MessageStatusID { get; set; } = null!;

    /// <summary>
    /// Sender
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;

    [Unicode(false)]
    public string MessageText { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    public int? QuotedMessageID { get; set; }

    [ForeignKey("MessageGroupID")]
    [InverseProperty("Message")]
    public virtual MessageGroup MessageGroup { get; set; } = null!;

    [ForeignKey("MessageStatusID")]
    [InverseProperty("Message")]
    public virtual MessageStatus MessageStatus { get; set; } = null!;

    [ForeignKey("UserID")]
    [InverseProperty("Message")]
    public virtual User User { get; set; } = null!;
}
