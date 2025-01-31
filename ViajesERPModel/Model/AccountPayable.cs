﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class AccountPayable
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string AccountPayableID { get; set; } = null!;

    public int AccountPayableNumber { get; set; }

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
    /// B.U.
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string ChannelID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string VendorID { get; set; } = null!;

    /// <summary>
    /// Tipo Documento
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string DocumentTypeID { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string DocumentID { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? DocumentDate { get; set; }

    /// <summary>
    /// Moneda
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string CurrencyID { get; set; } = null!;

    /// <summary>
    /// Condición de Pago
    /// </summary>
    [StringLength(36)]
    [Unicode(false)]
    public string? PaymentConditionID { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal OpenAmount { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [ForeignKey("BusinessUnitID")]
    [InverseProperty("AccountPayable")]
    public virtual BusinessUnit BusinessUnit { get; set; } = null!;

    [ForeignKey("ChannelID")]
    [InverseProperty("AccountPayable")]
    public virtual Channel Channel { get; set; } = null!;

    [ForeignKey("CurrencyID")]
    [InverseProperty("AccountPayable")]
    public virtual Currency Currency { get; set; } = null!;

    [ForeignKey("DocumentTypeID")]
    [InverseProperty("AccountPayable")]
    public virtual DocumentType DocumentType { get; set; } = null!;

    [InverseProperty("AccountPayable")]
    public virtual ICollection<VendorPaymentAccountPayable> VendorPaymentAccountPayable { get; } = new List<VendorPaymentAccountPayable>();
}
