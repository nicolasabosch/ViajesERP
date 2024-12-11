using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class File
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string FileID { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string FileName { get; set; } = null!;

    public byte[]? FileContent { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? FolderName { get; set; }

    public int? FileSize { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    public int? RemoteFileSize { get; set; }

    [InverseProperty("File")]
    public virtual ICollection<Product> Product { get; } = new List<Product>();

    [InverseProperty("File")]
    public virtual ICollection<ProductCategory> ProductCategory { get; } = new List<ProductCategory>();

    [InverseProperty("File")]
    public virtual ICollection<ReceiptFile> ReceiptFile { get; } = new List<ReceiptFile>();

    [InverseProperty("File")]
    public virtual ICollection<TripFile> TripFile { get; } = new List<TripFile>();
}
