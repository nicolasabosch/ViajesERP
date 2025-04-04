using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Index("CustomerID", Name = "IX_SaleOrder_CustomerID")]
[Index("SaleOrderStatusID", Name = "IX_SaleOrder_SaleOrderStatusID")]
[Index("SubCustomerID", Name = "IX_SaleOrder_SubCustomerID")]
public partial class SaleOrder
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleOrderID { get; set; } = null!;

    /// <summary>
    /// Número
    /// </summary>
    public int SaleOrderNumber { get; set; }

    /// <summary>
    /// Estado
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SaleOrderStatusID { get; set; } = null!;

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
    /// Lista de Precios
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? PriceListID { get; set; }

    /// <summary>
    /// Lista de Precios
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SubCustomerPriceListID { get; set; }

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
    public DateTime RequestedDate { get; set; }

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

    /// <summary>
    /// Vendedor
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SaleRepresentativeID { get; set; }

    /// <summary>
    /// Vendedor
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? OtherSaleRepresentativeID { get; set; }

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

    public bool? Printed { get; set; }

    /// <summary>
    /// Transportitsta
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? CarrierID { get; set; }

    /// <summary>
    /// Urgencia
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? UrgencyID { get; set; }

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
    public string? BusinessUnitID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? DeliveryZoneID { get; set; }

    public bool SaleOrderbyQuantity { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DeliveryInstruction { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedOn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedOn { get; set; }

    [Column(TypeName = "date")]
    public DateTime? SaleOrderDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? WorkflowID { get; set; }

    [Unicode(false)]
    public string? WorkflowJSON { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? ProductConditionID { get; set; }

    public DateTimeOffset? CommunicationDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? ProgrammerTeamID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? PurchaseDeliveryID { get; set; }

    [ForeignKey("CarrierID")]
    [InverseProperty("SaleOrder")]
    public virtual Carrier? Carrier { get; set; }

    [ForeignKey("ChannelID")]
    [InverseProperty("SaleOrder")]
    public virtual Channel Channel { get; set; } = null!;

    [ForeignKey("CurrencyID")]
    [InverseProperty("SaleOrder")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("CustomerID")]
    [InverseProperty("SaleOrder")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("DeliveryZoneID")]
    [InverseProperty("SaleOrder")]
    public virtual DeliveryZone? DeliveryZone { get; set; }

    [ForeignKey("PaymentConditionID")]
    [InverseProperty("SaleOrder")]
    public virtual PaymentCondition PaymentCondition { get; set; } = null!;

    [InverseProperty("SaleOrder")]
    public virtual ICollection<PickingOrder> PickingOrder { get; } = new List<PickingOrder>();

    [ForeignKey("PriceListID")]
    [InverseProperty("SaleOrder")]
    public virtual PriceList? PriceList { get; set; }

    [ForeignKey("ProductConditionID")]
    [InverseProperty("SaleOrder")]
    public virtual ProductCondition? ProductCondition { get; set; }

    [InverseProperty("SaleOrder")]
    public virtual ICollection<SaleDelivery> SaleDelivery { get; } = new List<SaleDelivery>();

    [InverseProperty("SaleOrder")]
    public virtual ICollection<SaleOrderItem> SaleOrderItem { get; } = new List<SaleOrderItem>();

    [ForeignKey("SaleOrderStatusID")]
    [InverseProperty("SaleOrder")]
    public virtual SaleOrderStatus SaleOrderStatus { get; set; } = null!;

    [ForeignKey("UrgencyID")]
    [InverseProperty("SaleOrder")]
    public virtual Urgency? Urgency { get; set; }
}
