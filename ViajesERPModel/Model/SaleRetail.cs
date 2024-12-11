using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class SaleRetail
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string SaleRetailID { get; set; } = null!;

    /// <summary>
    /// Número
    /// </summary>
    public int SaleRetailNumber { get; set; }

    /// <summary>
    /// Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    /// <summary>
    /// Sucursal
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitID { get; set; } = null!;

    /// <summary>
    /// Contacto
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? OrganizationUnitContactID { get; set; }

    /// <summary>
    /// Fecha
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime SaleRetailDate { get; set; }

    /// <summary>
    /// Moneda
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    /// <summary>
    /// Monto
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Amount { get; set; }

    /// <summary>
    /// Comentarios
    /// </summary>
    [StringLength(2000)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleRetailTypeCode { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ContactDescription { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OrganizationUnitContactName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CityName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DistrictName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ZipCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TaxCode { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? DeliveryInstruction { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TransportationName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TransportationAddress { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DeliveryDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CurrencyRateAmount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReturnType { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? FinancingAmount { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? DeliveryTypeID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleDeliveryOnTripStatusID { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleDeliveryRejectReasonID { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? SaleDeliveryOnTripRemarks { get; set; }

    public int? TripID { get; set; }

    [Column(TypeName = "date")]
    public DateTime? RealDeliveryDate { get; set; }

    [ForeignKey("CurrencyID")]
    [InverseProperty("SaleRetail")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("CustomerID")]
    [InverseProperty("SaleRetail")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("OrganizationUnitID")]
    [InverseProperty("SaleRetail")]
    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;

    [ForeignKey("OrganizationUnitContactID")]
    [InverseProperty("SaleRetail")]
    public virtual OrganizationUnitContact? OrganizationUnitContact { get; set; }

    [InverseProperty("SaleRetail")]
    public virtual ICollection<SaleRetailItem> SaleRetailItem { get; } = new List<SaleRetailItem>();

    [InverseProperty("SaleRetail")]
    public virtual ICollection<SaleRetailValue> SaleRetailValue { get; } = new List<SaleRetailValue>();

    [ForeignKey("TripID")]
    [InverseProperty("SaleRetail")]
    public virtual Trip? Trip { get; set; }

    [InverseProperty("SaleRetail")]
    public virtual ICollection<TripSaleRetail> TripSaleRetail { get; } = new List<TripSaleRetail>();
}
