using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup 
/// </summary>
public partial class VtProspectStatus
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public bool? IsActive { get; set; }

    public string? DisplayName { get; set; }

    public int? NextStateId { get; set; }

    public virtual ICollection<BranchClientCrmstatusHistory> BranchClientCrmstatusHistories { get; set; } = new List<BranchClientCrmstatusHistory>();
}
