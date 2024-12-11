using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Counterfoil
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CounterfoilID { get; set; } = null!;

    /// <summary>
    /// N° Mínimo
    /// </summary>
    public int MinNumber { get; set; }

    /// <summary>
    /// N° Máximo
    /// </summary>
    public int MaxNumber { get; set; }

    /// <summary>
    /// Impreso del X al Z
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string PrinterRange { get; set; } = null!;

    /// <summary>
    /// Fecha Impresion
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string PrinterPeriod { get; set; } = null!;

    /// <summary>
    /// CAI
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CAICode { get; set; } = null!;

    /// <summary>
    /// VTO CAI
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CAIDueDate { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }
}
