using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vThirdPartyFulltex
{
    [StringLength(36)]
    [Unicode(false)]
    public string ThirdPartyID { get; set; } = null!;

    [StringLength(202)]
    public string ThirdPartyName { get; set; } = null!;

    public int ThirdPartyNumber { get; set; }
}
