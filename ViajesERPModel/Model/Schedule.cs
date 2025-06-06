﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Schedule
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ScheduleID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? ScheduleCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string ScheduleName { get; set; } = null!;

    public bool Active { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("Schedule")]
    public virtual ICollection<TaskType> TaskType { get; } = new List<TaskType>();
}
