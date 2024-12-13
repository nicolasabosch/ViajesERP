using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Index("CustomerID", Name = "IX_SaleDelivery_CustomerID")]
[Index("SaleDeliveryStatusID", Name = "IX_SaleDelivery_SaleDeliveryStatusID")]
[Index("SubCustomerID", Name = "IX_SaleDelivery_SubCustomerID")]
public partial class SaleDelivery
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryID { get; set; } = null!;

    /// <summary>
    /// Número
    /// </summary>
    public int SaleDeliveryNumber { get; set; }

    /// <summary>
    /// Estado
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SaleDeliveryStatusID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string SaleOrderID { get; set; } = null!;

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
    [StringLength(200)]
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
    /// Moneda
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

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

    [StringLength(36)]
    [Unicode(false)]
    public string? UrgencyID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? DeliveryStatusID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? DeliveryStatusDescription { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CurrencyRateAmount { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? DeliveryZoneID { get; set; }

    public int? BundlesQuantity { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? DeliveryInstruction { get; set; }

    [Column(TypeName = "date")]
    public DateTime? SaleDeliveryDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? CurrentWarehouseGroupID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleDeliveryOnTripStatusID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleDeliveryRejectReasonID { get; set; }

    public int? TripID { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? SaleDeliveryOnTripRemarks { get; set; }

    [Column(TypeName = "date")]
    public DateTime? RealDeliveryDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? PickingOrderID { get; set; }

    [ForeignKey("CustomerID")]
    [InverseProperty("SaleDelivery")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("DeliveryZoneID")]
    [InverseProperty("SaleDelivery")]
    public virtual DeliveryZone? DeliveryZone { get; set; }

    [InverseProperty("SaleDelivery")]
    public virtual ICollection<SaleDeliveryItem> SaleDeliveryItem { get; } = new List<SaleDeliveryItem>();

    [InverseProperty("SaleDelivery")]
    public virtual ICollection<SaleDeliveryNote> SaleDeliveryNote { get; } = new List<SaleDeliveryNote>();

    [ForeignKey("SaleDeliveryOnTripStatusID")]
    [InverseProperty("SaleDelivery")]
    public virtual SaleDeliveryOnTripStatus? SaleDeliveryOnTripStatus { get; set; }

    [ForeignKey("SaleDeliveryRejectReasonID")]
    [InverseProperty("SaleDelivery")]
    public virtual SaleDeliveryRejectReason? SaleDeliveryRejectReason { get; set; }

    [ForeignKey("SaleDeliveryStatusID")]
    [InverseProperty("SaleDelivery")]
    public virtual SaleDeliveryStatus SaleDeliveryStatus { get; set; } = null!;

    [ForeignKey("SaleOrderID")]
    [InverseProperty("SaleDelivery")]
    public virtual SaleOrder SaleOrder { get; set; } = null!;

    [ForeignKey("TripID")]
    [InverseProperty("SaleDelivery")]
    public virtual Trip? Trip { get; set; }

    [InverseProperty("SaleDelivery")]
    public virtual ICollection<TripEvent> TripEvent { get; } = new List<TripEvent>();

    [InverseProperty("SaleDelivery")]
    public virtual ICollection<TripSaleDelivery> TripSaleDelivery { get; } = new List<TripSaleDelivery>();

    [ForeignKey("WarehousePositionID")]
    [InverseProperty("SaleDelivery")]
    public virtual WarehousePosition? WarehousePosition { get; set; }
}
