using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vReporteClientesTarot
{
    public int CustomerNumber { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? CustomerLegalName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DistrictName { get; set; }

    [StringLength(200)]
    public string? StateName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ZipCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ContactName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FiscalCode { get; set; }

    [StringLength(201)]
    public string? UserFullName { get; set; }
}
