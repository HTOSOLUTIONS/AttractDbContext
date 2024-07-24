using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup  
/// </summary>
public partial class VtBankAccountType
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public string? LookupValue { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<TalentBankAccount> TalentBankAccounts { get; set; } = new List<TalentBankAccount>();

    public virtual ICollection<TenantBankAccount> TenantBankAccounts { get; set; } = new List<TenantBankAccount>();
}
