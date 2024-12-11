using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vAllDocument
{
    public int DocumentNumber { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string DocumentID { get; set; } = null!;

    [StringLength(12)]
    [Unicode(false)]
    public string DocumentTypeID { get; set; } = null!;

    [StringLength(112)]
    [Unicode(false)]
    public string? ReferenceCode { get; set; }
}
