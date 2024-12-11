using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

[Index("CustomerName", Name = "IX_Customer_CustomerName")]
public partial class Customer
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    /// <summary>
    /// Nombre Fantasía
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    /// <summary>
    /// Razón Social
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? CustomerLegalName { get; set; }

    /// <summary>
    /// Código Interno
    /// </summary>
    public int CustomerNumber { get; set; }

    /// <summary>
    /// Clase de Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CustomerClassID { get; set; } = null!;

    /// <summary>
    /// Tipo de Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? CustomerTypeID { get; set; }

    /// <summary>
    /// Grupo de Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? CustomerGroupID { get; set; }

    /// <summary>
    /// Canal
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ChannelID { get; set; } = null!;

    /// <summary>
    /// Grupo de Ventas
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SaleGroupID { get; set; }

    /// <summary>
    /// Distrito de Ventas
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SaleDistrictID { get; set; }

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
    public string? CurrencyID { get; set; }

    /// <summary>
    /// Transportista
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? CarrierID { get; set; }

    /// <summary>
    /// Provincia
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? StateID { get; set; }

    /// <summary>
    /// Dirección
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

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
    /// Teléfono
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? Phone { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    /// <summary>
    /// Contacto
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? ContactName { get; set; }

    /// <summary>
    /// Código
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ParentCustomerID { get; set; }

    /// <summary>
    /// Límite de Crédito
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CreditLimit { get; set; }

    /// <summary>
    /// Multiplicador
    /// </summary>
    [Column(TypeName = "decimal(8, 4)")]
    public decimal? Multiplier { get; set; }

    /// <summary>
    /// Condición de Pago
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? PaymentConditionID { get; set; }

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
    /// IIBB
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? TaxCode { get; set; }

    /// <summary>
    /// IIBB
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? CrossReferenceCode { get; set; }

    /// <summary>
    /// Entrega
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? DeliveryInstruction { get; set; }

    public bool? UsesLabelCode { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    public bool Active { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? DeliveryZoneID { get; set; }

    [ForeignKey("CarrierID")]
    [InverseProperty("Customer")]
    public virtual Carrier? Carrier { get; set; }

    [ForeignKey("ChannelID")]
    [InverseProperty("Customer")]
    public virtual Channel Channel { get; set; } = null!;

    [InverseProperty("Customer")]
    public virtual ICollection<CreditNote> CreditNote { get; } = new List<CreditNote>();

    [ForeignKey("CurrencyID")]
    [InverseProperty("Customer")]
    public virtual Currency? Currency { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<CustomerBusinessUnit> CustomerBusinessUnit { get; } = new List<CustomerBusinessUnit>();

    [ForeignKey("CustomerClassID")]
    [InverseProperty("Customer")]
    public virtual CustomerClass CustomerClass { get; set; } = null!;

    [InverseProperty("Customer")]
    public virtual ICollection<CustomerDeliveryAddress> CustomerDeliveryAddress { get; } = new List<CustomerDeliveryAddress>();

    [ForeignKey("CustomerGroupID")]
    [InverseProperty("Customer")]
    public virtual CustomerGroup? CustomerGroup { get; set; }

    [ForeignKey("CustomerTypeID")]
    [InverseProperty("Customer")]
    public virtual CustomerType? CustomerType { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<DebitNote> DebitNote { get; } = new List<DebitNote>();

    [ForeignKey("DeliveryZoneID")]
    [InverseProperty("Customer")]
    public virtual DeliveryZone? DeliveryZone { get; set; }

    [ForeignKey("FiscalCodeTypeID")]
    [InverseProperty("Customer")]
    public virtual FiscalCodeType? FiscalCodeType { get; set; }

    [ForeignKey("PaymentConditionID")]
    [InverseProperty("Customer")]
    public virtual PaymentCondition? PaymentCondition { get; set; }

    [ForeignKey("PriceListID")]
    [InverseProperty("Customer")]
    public virtual PriceList? PriceList { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<SaleDelivery> SaleDelivery { get; } = new List<SaleDelivery>();

    [InverseProperty("Customer")]
    public virtual ICollection<SaleDeliveryNote> SaleDeliveryNote { get; } = new List<SaleDeliveryNote>();

    [ForeignKey("SaleDistrictID")]
    [InverseProperty("Customer")]
    public virtual SaleDistrict? SaleDistrict { get; set; }

    [ForeignKey("SaleGroupID")]
    [InverseProperty("Customer")]
    public virtual SaleGroup? SaleGroup { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<SaleOrder> SaleOrder { get; } = new List<SaleOrder>();

    [InverseProperty("Customer")]
    public virtual ICollection<SaleRetail> SaleRetail { get; } = new List<SaleRetail>();

    [ForeignKey("StateID")]
    [InverseProperty("Customer")]
    public virtual State? State { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<TransferOrder> TransferOrder { get; } = new List<TransferOrder>();

    [InverseProperty("Customer")]
    public virtual ICollection<WithdrawalOrder> WithdrawalOrder { get; } = new List<WithdrawalOrder>();
}
