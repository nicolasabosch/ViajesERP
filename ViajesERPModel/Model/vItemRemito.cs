using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vItemRemito
{
    [StringLength(31)]
    [Unicode(false)]
    public string? Comprobante { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryNoteID { get; set; } = null!;

    public int ItemComprobante { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Prom { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Cant { get; set; }

    [StringLength(200)]
    public string Unidad { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Rollos { get; set; }

    [StringLength(200)]
    public string Tela { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ProductID { get; set; } = null!;

    [StringLength(200)]
    public string Cod { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? Despacho { get; set; }

    [Column("Precio Unitario", TypeName = "decimal(37, 8)")]
    public decimal? Precio_Unitario { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? Total { get; set; }

    [Column("Nro Pedido")]
    public int Nro_Pedido { get; set; }

    [Column("Precio Lista", TypeName = "decimal(18, 4)")]
    public decimal? Precio_Lista { get; set; }

    [Column("Cantidad Pedida", TypeName = "decimal(18, 2)")]
    public decimal Cantidad_Pedida { get; set; }

    [Column("Bultos Pedidos", TypeName = "decimal(18, 2)")]
    public decimal? Bultos_Pedidos { get; set; }

    [Column("Moneda Reventa")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Moneda_Reventa { get; set; }

    [Column("Precio Reventa", TypeName = "decimal(18, 4)")]
    public decimal Precio_Reventa { get; set; }

    [Column("Total Reventa", TypeName = "decimal(37, 6)")]
    public decimal? Total_Reventa { get; set; }

    [StringLength(200)]
    public string? PaisOrigen { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Estacionalidad { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Composicion { get; set; }
}
