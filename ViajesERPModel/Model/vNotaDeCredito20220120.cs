﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Keyless]
public partial class vNotaDeCredito20220120
{
    public DateTimeOffset? Creacion { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? Comprobante { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CreditNoteID { get; set; } = null!;

    public int CreditNoteNumber { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CurrencyName { get; set; } = null!;

    [StringLength(80)]
    [Unicode(false)]
    public string? Remito { get; set; }

    [Column(TypeName = "date")]
    public DateTime Fecha { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string UN { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string Cuenta { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string Concepto { get; set; } = null!;

    [Column(TypeName = "decimal(20, 4)")]
    public decimal? Total { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string RazonSocial { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Recibe { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Subcliente { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? CUIT { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string CondicionIVA { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? Domicilio { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Transportista { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DomicilioTransporte { get; set; }

    [StringLength(201)]
    public string? Vendedor { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string DocumentStatusName { get; set; } = null!;

    public int CodigoCliente { get; set; }

    public int? CodigoSubcliente { get; set; }

    [Column("Moneda Reventa")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Moneda_Reventa { get; set; }

    [Column("Vendedor Reventa")]
    [StringLength(201)]
    public string? Vendedor_Reventa { get; set; }

    [Column("Total Reventa", TypeName = "decimal(20, 4)")]
    public decimal? Total_Reventa { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? ParentCreditNoteID { get; set; }
}