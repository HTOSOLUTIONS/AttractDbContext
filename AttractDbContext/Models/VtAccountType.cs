using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup 
/// </summary>
public partial class VtAccountType
{
    public int Id { get; set; }

    public string? AccountType { get; set; }

    public int? AccountSortOrder { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
