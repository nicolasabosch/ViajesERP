using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vProductLabelTypeCustomerDeliveryCode
{
    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string ProductCode { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ProductFamilyID { get; set; } = null!;

    [StringLength(200)]
    public string ProductName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string LabelTypeID { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? ReceptionDate { get; set; }

    public int? PurchaseReceptionNumber { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CustomDeliveryCode { get; set; }

    [StringLength(19)]
    [Unicode(false)]
    public string? Source { get; set; }
}
