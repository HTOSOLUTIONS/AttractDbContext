using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup  
/// </summary>
public partial class VtWagePeriod
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public string? LookupValue { get; set; }

    public bool? IsActive { get; set; }

    public int? PeriodDays { get; set; }

    public virtual ICollection<BranchEmployeeWage> BranchEmployeeWages { get; set; } = new List<BranchEmployeeWage>();

    public virtual ICollection<BranchJobOrderDirectHireDetail> BranchJobOrderDirectHireDetails { get; set; } = new List<BranchJobOrderDirectHireDetail>();
}
