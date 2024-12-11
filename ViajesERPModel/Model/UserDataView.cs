using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[PrimaryKey("UserID", "DataViewID")]
public partial class UserDataView
{
    /// <summary>
    /// User Id
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string DataViewID { get; set; } = null!;

    [Unicode(false)]
    public string FieldsSelection { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }
}
