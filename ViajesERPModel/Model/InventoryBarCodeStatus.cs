using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class InventoryBarCodeStatus
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string InventoryBarCodeStatusID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string InventoryBarCodeStatusName { get; set; } = null!;

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("InventoryBarCodeStatus")]
    public virtual ICollection<InventoryBarCode> InventoryBarCode { get; } = new List<InventoryBarCode>();
}
