using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vBatchPaymentTarot
{
    [Column(TypeName = "date")]
    public DateTime BatchPaymentDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ValueDate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ValueOwnerTax { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ValueOwnerName { get; set; }

    [StringLength(234)]
    [Unicode(false)]
    public string? Customer { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string BankName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? ValueText { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal Amount { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Salio { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Destino { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? EndorsableCustomerName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CheckStatusDescription { get; set; }

    [Column(TypeName = "date")]
    public DateTime? RejectionDate { get; set; }

    [StringLength(234)]
    [Unicode(false)]
    public string? SubCustomer { get; set; }

    public int BatchPaymentValueNumber { get; set; }

    public int BatchPaymentNumber { get; set; }
}
