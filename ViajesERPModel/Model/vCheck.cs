using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vCheck
{
    [StringLength(36)]
    [Unicode(false)]
    public string OU { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string B { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string Canal { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ValueTypeName { get; set; } = null!;

    [StringLength(234)]
    public string? Vendor { get; set; }

    public int? VendorPaymentNumber { get; set; }

    [Column(TypeName = "date")]
    public DateTime? VendorPaymentDate { get; set; }

    [StringLength(232)]
    [Unicode(false)]
    public string? Cliente { get; set; }

    [StringLength(233)]
    [Unicode(false)]
    public string? SubCustomerName { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ReceiptDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Banco { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? Sucursal { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ValueText { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ValueDate { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal Amount { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ValueOwnerTax { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Librador { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Estado { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CheckStatusDescription { get; set; }

    public int? ReceiptNumber { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EndorsableCustomerName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EndorsableCompanyName { get; set; }
}
