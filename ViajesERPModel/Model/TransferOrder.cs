using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class TransferOrder
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string TransferOrderID { get; set; } = null!;

    /// <summary>
    /// Número
    /// </summary>
    public int TransferOrderNumber { get; set; }

    /// <summary>
    /// Estado
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string TransferOrderStatusID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string PurchaseDeliveryID { get; set; } = null!;

    /// <summary>
    /// Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    /// <summary>
    /// SubCliente
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
    /// Código
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

    public int? SaleDeliveryNoteLegalPrefix { get; set; }

    public int? SaleDeliveryNoteLegalNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SaleDeliveryNoteSerialCode { get; set; }

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

    /// <summary>
    /// Vendedor
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SaleRepresentativeID { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal NetAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal GrossAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CommissionAmount { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("TransferOrder")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [ForeignKey("CarrierID")]
    [InverseProperty("TransferOrder")]
    public virtual Carrier? Carrier { get; set; }

    [ForeignKey("CurrencyID")]
    [InverseProperty("TransferOrder")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("CustomerID")]
    [InverseProperty("TransferOrder")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("PaymentConditionID")]
    [InverseProperty("TransferOrder")]
    public virtual PaymentCondition PaymentCondition { get; set; } = null!;

    [ForeignKey("PriceListID")]
    [InverseProperty("TransferOrder")]
    public virtual PriceList? PriceList { get; set; }

    [ForeignKey("PurchaseDeliveryID")]
    [InverseProperty("TransferOrder")]
    public virtual PurchaseDelivery PurchaseDelivery { get; set; } = null!;

    [InverseProperty("TransferOrder")]
    public virtual ICollection<TransferOrderItem> TransferOrderItem { get; } = new List<TransferOrderItem>();

    [ForeignKey("TransferOrderStatusID")]
    [InverseProperty("TransferOrder")]
    public virtual TransferOrderStatus TransferOrderStatus { get; set; } = null!;
}
