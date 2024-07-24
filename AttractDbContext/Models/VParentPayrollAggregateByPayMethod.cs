using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VParentPayrollAggregateByPayMethod
{
    public string? PayPeriodStatus { get; set; }

    public int BranchPayPeriodId { get; set; }

    public int? BranchId { get; set; }

    public DateOnly? PeriodStartDt { get; set; }

    public DateOnly? PeriodEndDt { get; set; }

    public DateOnly? PayDate { get; set; }

    public string? BranchName { get; set; }

    public int TenantId { get; set; }

    public string? TenantName { get; set; }

    public int? ParentTenantId { get; set; }

    public string? ParentTenantName { get; set; }

    public string PeriodType { get; set; } = null!;

    public DateTime? SubmittedDt { get; set; }

    public DateTime? ApprovedDt { get; set; }

    public int? CntPaperChecks { get; set; }

    public int? CntAch { get; set; }

    public int? CntPayCards { get; set; }

    public int? CntLargeChecks { get; set; }

    public int? CntLargeAch { get; set; }

    public int? CntLargePayCards { get; set; }

    public decimal? AmtPaperChecks { get; set; }

    public decimal? AmtAch { get; set; }

    public decimal? AmtPayCards { get; set; }
}
