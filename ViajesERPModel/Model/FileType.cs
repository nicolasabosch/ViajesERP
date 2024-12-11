using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class FileType
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string FileTypeID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string FileTypeName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("FileType")]
    public virtual ICollection<ReceiptFile> ReceiptFile { get; } = new List<ReceiptFile>();
}
