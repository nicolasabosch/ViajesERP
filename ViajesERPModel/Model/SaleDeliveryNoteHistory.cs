using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class SaleDeliveryNoteHistory
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryNoteHistoryID { get; set; } = null!;

    /// <summary>
    /// Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryID { get; set; } = null!;

    /// <summary>
    /// Cliente
    /// </summary>
    public int? SaleDeliveryNumber { get; set; }

    /// <summary>
    /// Cliente
    /// </summary>
    public int? SaleOrderNumber { get; set; }

    /// <summary>
    /// Vendedor
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SaleRepresentativeID { get; set; }

    /// <summary>
    /// Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    /// <summary>
    /// Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SubCustomerID { get; set; }

    /// <summary>
    /// Razón Social
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? CustomerLegalName { get; set; }

    /// <summary>
    /// IIBB
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? TaxCode { get; set; }

    /// <summary>
    /// Condición IVA
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? FiscalCodeTypeID { get; set; }

    /// <summary>
    /// CUIT
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? FiscalCode { get; set; }

    /// <summary>
    /// Provincia
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? StateID { get; set; }

    /// <summary>
    /// Localidad
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? DistrictName { get; set; }

    /// <summary>
    /// Código Postal
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? ZipCode { get; set; }

    /// <summary>
    /// Dirección
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }

    /// <summary>
    /// Teléfono
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Phone { get; set; }

    /// <summary>
    /// Lista de Precios
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? PriceListID { get; set; }

    /// <summary>
    /// Multiplicador
    /// </summary>
    [Column(TypeName = "decimal(8, 4)")]
    public decimal Multiplier { get; set; }

    /// <summary>
    /// Condición de Pago
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string PaymentConditionID { get; set; } = null!;

    /// <summary>
    /// Fecha
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime DeliveryDate { get; set; }

    /// <summary>
    /// Fecha real del remito
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? SaleDeliveryNoteDate { get; set; }

    /// <summary>
    /// Dock de carga
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? WarehousePositionID { get; set; }

    public int? SaleDeliveryNoteLegalPrefix { get; set; }

    public int? SaleDeliveryNoteLegalNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SaleDeliveryNoteSerialCode { get; set; }

    /// <summary>
    /// Transportitsta
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? CarrierID { get; set; }

    /// <summary>
    /// B.U.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    /// <summary>
    /// Canal
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ChannelID { get; set; } = null!;

    /// <summary>
    /// Comentarios
    /// </summary>
    [Unicode(false)]
    public string? Remarks { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DeliveryInstruction { get; set; }

    [ForeignKey("ChannelID")]
    [InverseProperty("SaleDeliveryNoteHistory")]
    public virtual Channel Channel { get; set; } = null!;

    [InverseProperty("SaleDeliveryNoteHistory")]
    public virtual ICollection<SaleDeliveryNoteHistoryItem> SaleDeliveryNoteHistoryItem { get; } = new List<SaleDeliveryNoteHistoryItem>();
}
