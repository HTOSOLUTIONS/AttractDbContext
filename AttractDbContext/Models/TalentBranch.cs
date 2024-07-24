using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Branches each talent is associated with, either by job application or employment.  
/// </summary>
public partial class TalentBranch
{
    public int Id { get; set; }

    public int? TalentId { get; set; }

    public int? BranchId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public virtual TenantBranch? Branch { get; set; }

    public virtual Talent? Talent { get; set; }
}
