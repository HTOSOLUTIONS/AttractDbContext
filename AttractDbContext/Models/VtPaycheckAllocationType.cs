using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup  
/// </summary>
public partial class VtPaycheckAllocationType
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public string? LookupValue { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<BranchEmployeePayAllocation> BranchEmployeePayAllocations { get; set; } = new List<BranchEmployeePayAllocation>();
}
