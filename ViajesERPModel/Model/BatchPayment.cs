using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class BatchPayment
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string BatchPaymentID { get; set; } = null!;

    /// <summary>
    /// Referencia
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? BatchPaymentCode { get; set; }

    /// <summary>
    /// Número
    /// </summary>
    public int BatchPaymentNumber { get; set; }

    /// <summary>
    /// U.O.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitID { get; set; } = null!;

    /// <summary>
    /// B.U.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string BusinessUnitID { get; set; } = null!;

    /// <summary>
    /// B.U.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string SourceBusinessUnitID { get; set; } = null!;

    /// <summary>
    /// Canal
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ChannelID { get; set; } = null!;

    /// <summary>
    /// Fecha
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime BatchPaymentDate { get; set; }

    /// <summary>
    /// Comentarios
    /// </summary>
    [StringLength(4000)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    /// <summary>
    /// Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    /// <summary>
    /// ReceiptID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ReceiptID { get; set; }

    /// <summary>
    /// DistributorReceiptID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? DistributorReceiptID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string LastModifiedBy { get; set; } = null!;

    [InverseProperty("BatchPayment")]
    public virtual ICollection<BatchPaymentValue> BatchPaymentValue { get; } = new List<BatchPaymentValue>();

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("BatchPayment")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [ForeignKey("ChannelID")]
    [InverseProperty("BatchPayment")]
    public virtual Channel Channel { get; set; } = null!;

    [ForeignKey("OrganizationUnitID")]
    [InverseProperty("BatchPayment")]
    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;
}
