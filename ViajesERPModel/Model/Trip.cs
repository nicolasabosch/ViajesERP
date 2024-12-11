using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class Trip
{
    [Key]
    public int TripID { get; set; }

    [Column(TypeName = "date")]
    public DateTime TripDate { get; set; }

    /// <summary>
    /// Estado
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string TripStatusID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string TripTypeID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string WarehouseGroupID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string? DeliveryZoneID { get; set; }

    /// <summary>
    /// Flete
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? FreightID { get; set; }

    /// <summary>
    /// Vehiculo
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? VehicleTypeID { get; set; }

    /// <summary>
    /// Conductor
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? DriverName { get; set; }

    /// <summary>
    /// Chapa
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? PlateName { get; set; }

    /// <summary>
    /// Costo Viaje
    /// </summary>
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TripCostAmount { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? DestinationWarehouseGroupID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("DeliveryZoneID")]
    [InverseProperty("Trip")]
    public virtual DeliveryZone? DeliveryZone { get; set; }

    [ForeignKey("FreightID")]
    [InverseProperty("Trip")]
    public virtual Freight? Freight { get; set; }

    [InverseProperty("Trip")]
    public virtual ICollection<SaleDelivery> SaleDelivery { get; } = new List<SaleDelivery>();

    [InverseProperty("Trip")]
    public virtual ICollection<SaleRetail> SaleRetail { get; } = new List<SaleRetail>();

    [InverseProperty("Trip")]
    public virtual ICollection<TripFile> TripFile { get; } = new List<TripFile>();

    [InverseProperty("Trip")]
    public virtual ICollection<TripSaleDelivery> TripSaleDelivery { get; } = new List<TripSaleDelivery>();

    [InverseProperty("Trip")]
    public virtual ICollection<TripSaleRetail> TripSaleRetail { get; } = new List<TripSaleRetail>();

    [ForeignKey("TripStatusID")]
    [InverseProperty("Trip")]
    public virtual TripStatus TripStatus { get; set; } = null!;

    [ForeignKey("TripTypeID")]
    [InverseProperty("Trip")]
    public virtual TripType TripType { get; set; } = null!;

    [InverseProperty("Trip")]
    public virtual ICollection<TripWithdrawalOrder> TripWithdrawalOrder { get; } = new List<TripWithdrawalOrder>();

    [ForeignKey("WarehouseGroupID")]
    [InverseProperty("Trip")]
    public virtual WarehouseGroup WarehouseGroup { get; set; } = null!;

    [InverseProperty("Trip")]
    public virtual ICollection<WithdrawalOrder> WithdrawalOrder { get; } = new List<WithdrawalOrder>();
}
