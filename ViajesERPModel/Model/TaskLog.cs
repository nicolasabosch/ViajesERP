using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class TaskLog
{
    [Key]
    public long TaskLogID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string TaskTypeID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TaskStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TaskEndDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string TaskLogStatusID { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime ImputationDate { get; set; }

    [Unicode(false)]
    public string? TaskDetails { get; set; }

    [ForeignKey("TaskLogStatusID")]
    [InverseProperty("TaskLog")]
    public virtual TaskLogStatus TaskLogStatus { get; set; } = null!;

    [ForeignKey("TaskTypeID")]
    [InverseProperty("TaskLog")]
    public virtual TaskType TaskType { get; set; } = null!;
}
