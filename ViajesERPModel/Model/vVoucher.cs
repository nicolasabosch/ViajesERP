using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vVoucher
{
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentID { get; set; } = null!;

    public int DocumentNumber { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string DocumentTypeID { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? LegalPrefix { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? LegalNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SerialCode { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? SubCustomerID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? DocumentSubTypeID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DocumentSubTypeName { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? ReceiptID { get; set; }
}
