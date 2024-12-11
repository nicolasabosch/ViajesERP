using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class WithdrawalOrder
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string WithdrawalOrderID { get; set; } = null!;

    /// <summary>
    /// Número
    /// </summary>
    public int WithdrawalOrderNumber { get; set; }

    /// <summary>
    /// Estado
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string WithdrawalOrderStatusID { get; set; } = null!;

    /// <summary>
    /// Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    /// <summary>
    /// Fecha
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime RequestedDate { get; set; }

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
    /// Transportitsta
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? CarrierID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? BusinessUnitID { get; set; }

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

    [StringLength(5000)]
    [Unicode(false)]
    public string? DeliveryInstruction { get; set; }

    [Column(TypeName = "date")]
    public DateTime? RealDeliveryDate { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? DeliveryZoneID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedOn { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? WarehouseID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("WithdrawalOrder")]
    public virtual BusinessUnit? BusinessUnit { get; set; }

    [ForeignKey("CarrierID")]
    [InverseProperty("WithdrawalOrder")]
    public virtual Carrier? Carrier { get; set; }

    [ForeignKey("CustomerID")]
    [InverseProperty("WithdrawalOrder")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("DeliveryZoneID")]
    [InverseProperty("WithdrawalOrder")]
    public virtual DeliveryZone? DeliveryZone { get; set; }

    [ForeignKey("FiscalCodeTypeID")]
    [InverseProperty("WithdrawalOrder")]
    public virtual FiscalCodeType? FiscalCodeType { get; set; }

    [ForeignKey("SaleDeliveryRejectReasonID")]
    [InverseProperty("WithdrawalOrder")]
    public virtual SaleDeliveryRejectReason? SaleDeliveryRejectReason { get; set; }

    [ForeignKey("StateID")]
    [InverseProperty("WithdrawalOrder")]
    public virtual State? State { get; set; }

    [ForeignKey("TripID")]
    [InverseProperty("WithdrawalOrder")]
    public virtual Trip? Trip { get; set; }

    [ForeignKey("WarehouseID")]
    [InverseProperty("WithdrawalOrder")]
    public virtual Warehouse? Warehouse { get; set; }

    [InverseProperty("WithdrawalOrder")]
    public virtual ICollection<WithdrawalOrderItem> WithdrawalOrderItem { get; } = new List<WithdrawalOrderItem>();

    [ForeignKey("WithdrawalOrderStatusID")]
    [InverseProperty("WithdrawalOrder")]
    public virtual WithdrawalOrderStatus WithdrawalOrderStatus { get; set; } = null!;
}
