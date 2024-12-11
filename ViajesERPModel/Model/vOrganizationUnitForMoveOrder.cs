using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vOrganizationUnitForMoveOrder
{
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string OrganizationUnitName { get; set; } = null!;
}
