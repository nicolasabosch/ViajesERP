using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vUnReadMessage
{
    public int UnReadCount { get; set; }

    public int MessageGroupID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;
}
