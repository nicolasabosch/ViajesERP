using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class DebitNote
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string DebitNoteID { get; set; } = null!;

    /// <summary>
    /// Número NC
    /// </summary>
    public int DebitNoteNumber { get; set; }

    /// <summary>
    /// Fecha
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime DebitNoteDate { get; set; }

    /// <summary>
    /// Estado
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentStatusID { get; set; } = null!;

    /// <summary>
    /// SubTipo Documento
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? DocumentSubTypeID { get; set; }

    /// <summary>
    /// Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CustomerID { get; set; } = null!;

    /// <summary>
    /// Sub Cliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SubCustomerID { get; set; }

    /// <summary>
    /// Vendedor
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SaleRepresentativeID { get; set; }

    /// <summary>
    /// O.U.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitID { get; set; } = null!;

    /// <summary>
    /// Código
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
    /// Moneda
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    /// <summary>
    /// Monto
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal DebitAmount { get; set; }

    /// <summary>
    /// Gastos
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal ExpenseAmount { get; set; }

    /// <summary>
    /// Monto Total
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Monto Total Comisión
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal TotalCommissionAmount { get; set; }

    public int? DebitNoteLegalPrefix { get; set; }

    public int? DebitNoteLegalNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DebitNoteSerialCode { get; set; }

    /// <summary>
    /// Comentarios
    /// </summary>
    [Unicode(false)]
    public string? Remarks { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? ReceiptID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("DebitNote")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [ForeignKey("ChannelID")]
    [InverseProperty("DebitNote")]
    public virtual Channel Channel { get; set; } = null!;

    [ForeignKey("CurrencyID")]
    [InverseProperty("DebitNote")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("CustomerID")]
    [InverseProperty("DebitNote")]
    public virtual Customer Customer { get; set; } = null!;

    [InverseProperty("DebitNote")]
    public virtual ICollection<DebitNoteCheck> DebitNoteCheck { get; } = new List<DebitNoteCheck>();

    [ForeignKey("DocumentStatusID")]
    [InverseProperty("DebitNote")]
    public virtual DocumentStatus DocumentStatus { get; set; } = null!;

    [ForeignKey("DocumentSubTypeID")]
    [InverseProperty("DebitNote")]
    public virtual DocumentSubType? DocumentSubType { get; set; }

    [ForeignKey("OrganizationUnitID")]
    [InverseProperty("DebitNote")]
    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;

    [ForeignKey("ReceiptID")]
    [InverseProperty("DebitNote")]
    public virtual Receipt? Receipt { get; set; }

    [ForeignKey("SaleRepresentativeID")]
    [InverseProperty("DebitNote")]
    public virtual User? SaleRepresentative { get; set; }
}
