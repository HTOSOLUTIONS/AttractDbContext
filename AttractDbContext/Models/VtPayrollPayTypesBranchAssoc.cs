using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup  
/// </summary>
public partial class VtPayrollPayTypesBranchAssoc
{
    public int Id { get; set; }

    public int? PayTypeId { get; set; }

    public int? BranchId { get; set; }

    public bool? IsActive { get; set; }

    public string? PayTypeAlias { get; set; }

    public virtual TenantBranch? Branch { get; set; }

    public virtual VtPayrollPayType? PayType { get; set; }
}
