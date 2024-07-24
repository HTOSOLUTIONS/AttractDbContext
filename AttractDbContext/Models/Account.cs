using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Row by row detail on chart of accounts - FK to ChartofAccountsDefintion
/// </summary>
public partial class Account
{
    public int Id { get; set; }

    public int? CoAdefId { get; set; }

    public string? AccountNumber { get; set; }

    public string? AccountName { get; set; }

    public int? AccountTypeId { get; set; }

    public int? AccountCategoryId { get; set; }

    public int? AccountClassification { get; set; }

    public int? ParentAccountId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public string? StatementName { get; set; }

    public string? AccountDefinition { get; set; }

    public virtual VtAccountCategory? AccountCategory { get; set; }

    public virtual VtAccountClassification? AccountClassificationNavigation { get; set; }

    public virtual VtAccountType? AccountType { get; set; }

    public virtual ChartOfAccountsDefinition? CoAdef { get; set; }

    public virtual ICollection<LedgerEntry> LedgerEntries { get; set; } = new List<LedgerEntry>();
}
