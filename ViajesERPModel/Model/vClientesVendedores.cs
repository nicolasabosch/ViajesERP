using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vClientesVendedores
{
    public int CodigoCliente { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string NombreCliente { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string UnidadNegocio { get; set; } = null!;

    [StringLength(201)]
    public string Vendedor { get; set; } = null!;
}
