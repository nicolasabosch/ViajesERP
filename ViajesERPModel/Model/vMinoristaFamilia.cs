using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vMinoristaFamilia
{
    public int Numero { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string IDCliente { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string IDUnidadOrganizacional { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? NombreContactoDeUO { get; set; }

    [Column(TypeName = "date")]
    public DateTime Fecha { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string Moneda { get; set; } = null!;

    [StringLength(2000)]
    [Unicode(false)]
    public string? Comentario { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Operacion { get; set; } = null!;

    [StringLength(200)]
    public string? Familia { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? Cantidad { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? PrecioUnitario { get; set; }
}
