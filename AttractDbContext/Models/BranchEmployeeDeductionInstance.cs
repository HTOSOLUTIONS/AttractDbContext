using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Sets up a garnishment or deduction method and type for employee paychecks.  
/// </summary>
public partial class BranchEmployeeDeductionInstance
{
    public int Id { get; set; }

    public int? BranchEmployeeId { get; set; }

    public int? DeductionTypeId { get; set; }

    public int? DeductionMethodId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? DeductionPct { get; set; }

    public decimal? DeductionbyPctLimit { get; set; }

    public decimal? DeductionAmountAbs { get; set; }

    public decimal? StandardAmount { get; set; }

    public decimal? DeductAllExcept { get; set; }

    public decimal? OverrideAmount { get; set; }

    public decimal? Minimum { get; set; }

    public decimal? Maximum { get; set; }

    public decimal? MinimumExceptWages { get; set; }

    public decimal? MaximumExceptWages { get; set; }

    public decimal? PctofGrossWages { get; set; }

    public decimal? PctofDisposalWages { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public decimal? EmployerMedicalMatch { get; set; }

    public decimal? EmployerContributionPct { get; set; }

    public decimal? OriginalBalance { get; set; }

    public int? PriorityOrder { get; set; }

    public decimal? MaxDisposableIncome { get; set; }

    public string? DeductionInstanceLabel { get; set; }

    public int? ResetInterval { get; set; }

    public bool? IsReadyForUse { get; set; }

    public virtual BranchEmployee? BranchEmployee { get; set; }

    public virtual ICollection<BranchEmployeeDeductionInstanceItem> BranchEmployeeDeductionInstanceItems { get; set; } = new List<BranchEmployeeDeductionInstanceItem>();

    public virtual VtPayrollDeductionTypesBranchAssoc? DeductionType { get; set; }
}
