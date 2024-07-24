using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Chart of Accounts definition - associates a branch with a chart, and includes a parent chart if applicable
/// </summary>
public partial class ChartOfAccountsDefinition
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int ParentGlcoAdefId { get; set; }

    public int DerivedFromCoAdefId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual TenantBranch? Branch { get; set; }
}
