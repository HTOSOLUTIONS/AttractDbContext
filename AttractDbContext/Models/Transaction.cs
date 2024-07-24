using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// IN PROGRESS - 
/// </summary>
public partial class Transaction
{
    public int Id { get; set; }

    public int? DocumentId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? TransactionDescrip { get; set; }

    public int? BranchId { get; set; }

    public int? TransactionStatus { get; set; }

    public virtual TenantBranch? Branch { get; set; }

    public virtual ICollection<LedgerEntry> LedgerEntries { get; set; } = new List<LedgerEntry>();

    public virtual VtTransactionStatus? TransactionStatusNavigation { get; set; }
}
