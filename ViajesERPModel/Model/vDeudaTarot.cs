using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vDeudaTarot
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

    [Column(TypeName = "decimal(18, 4)")]
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal OpenAmount { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string Tipo { get; set; } = null!;

    [StringLength(201)]
    public string Vendedor { get; set; } = null!;
}
