using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajesERPModel.Model;

public partial class User
{
    /// <summary>
    /// User Id
    /// </summary>
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;

    /// <summary>
    /// Login
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string UserName { get; set; } = null!;

    /// <summary>
    /// Password
    /// </summary>
    [StringLength(100)]
    public string Password { get; set; } = null!;

    /// <summary>
    /// Nombre
    /// </summary>
    [StringLength(100)]
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Apellido
    /// </summary>
    [StringLength(100)]
    public string LastName { get; set; } = null!;

    /// <summary>
    /// Activo
    /// </summary>
    public bool Active { get; set; }

    /// <summary>
    /// Forzar Cambio Contraseña
    /// </summary>
    public bool? ForceChangePassword { get; set; }

    /// <summary>
    /// E Mail
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    /// <summary>
    /// Último Login
    /// </summary>
    public DateTimeOffset? LastLogon { get; set; }

    /// <summary>
    /// Recibe Notificaciones
    /// </summary>
    public bool? ReceiveNotification { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? SaleChannelID { get; set; }

    public DateTimeOffset? CreatedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModifiedOn { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [InverseProperty("SaleRepresentative")]
    public virtual ICollection<CommissionPayable> CommissionPayable { get; } = new List<CommissionPayable>();

    [InverseProperty("SaleRepresentative")]
    public virtual ICollection<CustomerBusinessUnit> CustomerBusinessUnit { get; } = new List<CustomerBusinessUnit>();

    [InverseProperty("SaleRepresentative")]
    public virtual ICollection<DebitNote> DebitNote { get; } = new List<DebitNote>();

    [InverseProperty("User")]
    public virtual ICollection<Message> Message { get; } = new List<Message>();

    [InverseProperty("User")]
    public virtual ICollection<MessageGroupUser> MessageGroupUser { get; } = new List<MessageGroupUser>();

    [InverseProperty("User")]
    public virtual ICollection<MessageUser> MessageUser { get; } = new List<MessageUser>();

    [ForeignKey("SaleChannelID")]
    [InverseProperty("User")]
    public virtual SaleChannel? SaleChannel { get; set; }

    [InverseProperty("SaleRepresentative")]
    public virtual ICollection<SaleRepresentativePayment> SaleRepresentativePayment { get; } = new List<SaleRepresentativePayment>();

    [InverseProperty("User")]
    public virtual ICollection<TeamUser> TeamUser { get; } = new List<TeamUser>();

    [InverseProperty("User")]
    public virtual ICollection<UserMenuItem> UserMenuItem { get; } = new List<UserMenuItem>();

    [InverseProperty("User")]
    public virtual ICollection<UserRole> UserRole { get; } = new List<UserRole>();
}
