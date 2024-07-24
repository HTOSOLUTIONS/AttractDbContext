using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Encrypted bank account information for Tenant EFT payments.  
/// </summary>
public partial class TenantBankAccount
{
    public int Id { get; set; }

    public int? TenantId { get; set; }

    public int? AccountTypeId { get; set; }

    public string? RoutingNumEncrypted { get; set; }

    public string? AccountNumEncrypted { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public string? Address { get; set; }

    public string? BankName { get; set; }

    public string? FractionalRouting1 { get; set; }

    public string? FractionalRouting2 { get; set; }

    public virtual VtBankAccountType? AccountType { get; set; }

    public virtual Tenant? Tenant { get; set; }
}
