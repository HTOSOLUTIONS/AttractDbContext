using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Gives a BranchEmployee a salary 
/// </summary>
public partial class BranchEmployeeWage
{
    public int Id { get; set; }

    public int? BranchEmployeeId { get; set; }

    public DateTime WageStartDt { get; set; }

    public DateTime WageEndDt { get; set; }

    public bool? IsActive { get; set; }

    public int? WagePeriodId { get; set; }

    public decimal? AnnualWageAmount { get; set; }

    public decimal? HrlyRegWageAmount { get; set; }

    public decimal? HrlyOtwageAmount { get; set; }

    public decimal? HrlyDoubleWageAmount { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public int? AssignmentId { get; set; }

    public virtual BranchEmployee? BranchEmployee { get; set; }

    public virtual VtWagePeriod? WagePeriod { get; set; }
}
