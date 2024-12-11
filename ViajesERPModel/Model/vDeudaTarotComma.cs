using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vDeudaTarotComma
{
    [StringLength(200)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    public int CustomerNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    public int? SaleDeliveryNoteLegalNumber { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DocumentDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DueDate { get; set; }

    public int? DiasVencido { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? PaymentConditionID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    [StringLength(8000)]
    [Unicode(false)]
    public string? TotalAmount { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? OpenAmount { get; set; }
}
