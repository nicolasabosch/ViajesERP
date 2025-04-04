using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class CreditNote
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CreditNoteID { get; set; } = null!;

    /// <summary>
    /// Número NC
    /// </summary>
    public int CreditNoteNumber { get; set; }

    /// <summary>
    /// Fecha
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime CreditNoteDate { get; set; }

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

    /// <summary>
    /// Vendedor
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SaleRepresentativeID { get; set; }

    /// <summary>
    /// O. U.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitID { get; set; } = null!;

    /// <summary>
    /// Moneda
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    /// <summary>
    /// Moneda Subcliente
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? SubCustomerCurrencyID { get; set; }

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
    /// Monto Total
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Monto Total Comisión
    /// </summary>
    [Column(TypeName = "decimal(18, 4)")]
    public decimal TotalCommissionAmount { get; set; }

    /// <summary>
    /// Comentarios
    /// </summary>
    [Unicode(false)]
    public string? Remarks { get; set; }

    public int? CreditNoteLegalPrefix { get; set; }

    public int? CreditNoteLegalNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreditNoteSerialCode { get; set; }

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

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? SubCustomerTotalAmount { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? ParentCreditNoteID { get; set; }

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("CreditNote")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [ForeignKey("ChannelID")]
    [InverseProperty("CreditNote")]
    public virtual Channel Channel { get; set; } = null!;

    [InverseProperty("CreditNote")]
    public virtual ICollection<CreditNoteItem> CreditNoteItem { get; } = new List<CreditNoteItem>();

    [ForeignKey("CurrencyID")]
    [InverseProperty("CreditNote")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("DocumentStatusID")]
    [InverseProperty("CreditNote")]
    public virtual DocumentStatus DocumentStatus { get; set; } = null!;

    [ForeignKey("DocumentSubTypeID")]
    [InverseProperty("CreditNote")]
    public virtual DocumentSubType? DocumentSubType { get; set; }

    [ForeignKey("OrganizationUnitID")]
    [InverseProperty("CreditNote")]
    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;

    [ForeignKey("ReceiptID")]
    [InverseProperty("CreditNote")]
    public virtual Receipt? Receipt { get; set; }
}
