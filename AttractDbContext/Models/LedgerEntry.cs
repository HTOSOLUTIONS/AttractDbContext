using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// IN PROGRESS - 
/// </summary>
public partial class LedgerEntry
{
    public long Id { get; set; }

    public int? TransactionId { get; set; }

    public int? AccountId { get; set; }

    public string EntryType { get; set; } = null!;

    public decimal Amount { get; set; }

    public virtual Account? Account { get; set; }

    public virtual Transaction? Transaction { get; set; }
}
