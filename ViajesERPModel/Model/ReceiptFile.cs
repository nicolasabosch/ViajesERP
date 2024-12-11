using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class ReceiptFile
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string ReceiptFileID { get; set; } = null!;

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ReceiptID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string FileID { get; set; } = null!;

    /// <summary>
    /// Tipo
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string FileTypeID { get; set; } = null!;

    [StringLength(2000)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("FileID")]
    [InverseProperty("ReceiptFile")]
    public virtual File File { get; set; } = null!;

    [ForeignKey("FileTypeID")]
    [InverseProperty("ReceiptFile")]
    public virtual FileType FileType { get; set; } = null!;

    [ForeignKey("ReceiptID")]
    [InverseProperty("ReceiptFile")]
    public virtual Receipt Receipt { get; set; } = null!;
}
