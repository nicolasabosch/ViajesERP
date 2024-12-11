using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Task
{
    [Key]
    public long TaskID { get; set; }

    /// <summary>
    /// Tipo
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string TaskTypeID { get; set; } = null!;

    /// <summary>
    /// Estado
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string TaskStatusID { get; set; } = null!;

    /// <summary>
    /// Condición
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string TaskConditionID { get; set; } = null!;

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? TeamID { get; set; }

    /// <summary>
    /// Table
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    /// <summary>
    /// PK
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string TableKey { get; set; } = null!;

    public int TaskOrder { get; set; }

    [Unicode(false)]
    public string? TaskScript { get; set; }

    [Unicode(false)]
    public string? ResponseText { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? RoleID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? NodeID { get; set; }

    public DateTimeOffset? AvailableOn { get; set; }

    public DateTimeOffset? NotifiedOn { get; set; }

    public DateTimeOffset? FinishedOn { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? FinishedBy { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("TaskConditionID")]
    [InverseProperty("Task")]
    public virtual TaskCondition TaskCondition { get; set; } = null!;

    [ForeignKey("TaskStatusID")]
    [InverseProperty("Task")]
    public virtual TaskStatus TaskStatus { get; set; } = null!;

    [ForeignKey("TaskTypeID")]
    [InverseProperty("Task")]
    public virtual TaskType TaskType { get; set; } = null!;

    [ForeignKey("TeamID")]
    [InverseProperty("Task")]
    public virtual Team? Team { get; set; }
}
