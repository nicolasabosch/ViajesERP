using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class OrganizationUnit
{
    /// <summary>
    /// Código
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string OrganizationUnitID { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string OrganizationUnitName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? OrganizationUnitDescription { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    public bool UseCashDesk { get; set; }

    public bool MoveProduct { get; set; }

    public int? DisplayOrder { get; set; }

    [InverseProperty("OrganizationUnit")]
    public virtual ICollection<BatchPayment> BatchPayment { get; } = new List<BatchPayment>();

    [InverseProperty("OrganizationUnit")]
    public virtual ICollection<CashDesk> CashDesk { get; } = new List<CashDesk>();

    [InverseProperty("OrganizationUnit")]
    public virtual ICollection<CreditNote> CreditNote { get; } = new List<CreditNote>();

    [InverseProperty("OrganizationUnit")]
    public virtual ICollection<DebitNote> DebitNote { get; } = new List<DebitNote>();

    [InverseProperty("OrganizationUnit")]
    public virtual ICollection<Journal> Journal { get; } = new List<Journal>();

    [InverseProperty("OrganizationUnit")]
    public virtual ICollection<OrganizationUnitContact> OrganizationUnitContact { get; } = new List<OrganizationUnitContact>();

    [InverseProperty("OrganizationUnit")]
    public virtual ICollection<PaymentDeclare> PaymentDeclare { get; } = new List<PaymentDeclare>();

    [InverseProperty("OrganizationUnit")]
    public virtual ICollection<Receipt> Receipt { get; } = new List<Receipt>();

    [InverseProperty("OrganizationUnit")]
    public virtual ICollection<SaleRepresentativePayment> SaleRepresentativePayment { get; } = new List<SaleRepresentativePayment>();

    [InverseProperty("OrganizationUnit")]
    public virtual ICollection<SaleRetail> SaleRetail { get; } = new List<SaleRetail>();

    [InverseProperty("OrganizationUnit")]
    public virtual ICollection<SaleRetailCredit> SaleRetailCredit { get; } = new List<SaleRetailCredit>();

    [InverseProperty("OrganizationUnit")]
    public virtual ICollection<VendorPayment> VendorPayment { get; } = new List<VendorPayment>();
}
