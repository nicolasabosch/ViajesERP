using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class TaskType
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string TaskTypeID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string TaskTypeName { get; set; } = null!;

    /// <summary>
    /// Clase
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string TaskClassID { get; set; } = null!;

    /// <summary>
    /// Orden
    /// </summary>
    public int ExecutionOrder { get; set; }

    /// <summary>
    /// Agenda
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ScheduleID { get; set; }

    /// <summary>
    /// Activo
    /// </summary>
    public bool Active { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("ScheduleID")]
    [InverseProperty("TaskType")]
    public virtual Schedule? Schedule { get; set; }

    [InverseProperty("TaskType")]
    public virtual ICollection<Task> Task { get; } = new List<Task>();

    [ForeignKey("TaskClassID")]
    [InverseProperty("TaskType")]
    public virtual TaskClass TaskClass { get; set; } = null!;

    [InverseProperty("TaskType")]
    public virtual ICollection<TaskLog> TaskLog { get; } = new List<TaskLog>();
}
