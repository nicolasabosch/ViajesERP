using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vRemitoTotalConSaleRetail
{
    [StringLength(6)]
    [Unicode(false)]
    public string? Comprobante { get; set; }

    public int? SubComprobante { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? Remito { get; set; }

    [StringLength(201)]
    public string? Vendedor { get; set; }

    [Column("Nro Pedido")]
    public int? Nro_Pedido { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Fecha { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? UN { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? Cuenta { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Concepto { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? Detalle { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? RazonSocial { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Recibe { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Subcliente { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CUIT { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? CondicionIVA { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Domicilio { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Transportista { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DomicilioTransporte { get; set; }

    public int? ItemComprobante { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? Prom { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? Cant { get; set; }

    [StringLength(200)]
    public string? Unidad { get; set; }

    [Column("Cantidad Pedida", TypeName = "decimal(38, 2)")]
    public decimal? Cantidad_Pedida { get; set; }

    [Column("Bultos Pedidos", TypeName = "decimal(18, 2)")]
    public decimal? Bultos_Pedidos { get; set; }

    [Column("Precio Lista", TypeName = "decimal(38, 6)")]
    public decimal? Precio_Lista { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Rollos { get; set; }

    [StringLength(200)]
    public string? Tela { get; set; }

    [StringLength(200)]
    public string? Cod { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Despacho { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Moneda { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? PrecioUnitario { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? Total { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Estado { get; set; }

    [Column("Moneda Reventa")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Moneda_Reventa { get; set; }

    [Column("Precio Reventa", TypeName = "decimal(38, 6)")]
    public decimal? Precio_Reventa { get; set; }

    [Column("Total Reventa", TypeName = "decimal(38, 6)")]
    public decimal? Total_Reventa { get; set; }

    public int CodigoCliente { get; set; }

    public int? CodigoSubCliente { get; set; }

    [Column("Vendedor Reventa")]
    [StringLength(201)]
    public string? Vendedor_Reventa { get; set; }

    [Column("Fecha Pedido", TypeName = "date")]
    public DateTime? Fecha_Pedido { get; set; }
}
