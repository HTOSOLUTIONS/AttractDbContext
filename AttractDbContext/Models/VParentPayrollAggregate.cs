using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VParentPayrollAggregate
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

    public int InvoiceCreated { get; set; }

    public bool IsInitiated { get; set; }

    public bool IsSubmitted { get; set; }

    public bool IsApproved { get; set; }

    public string PeriodType { get; set; } = null!;

    public DateTime? SubmittedDt { get; set; }

    public DateTime? ApprovedDt { get; set; }

    public decimal? TotalHours { get; set; }

    public decimal? GrossPay { get; set; }

    public decimal? BillAmount { get; set; }

    public int? HasPaperChecks { get; set; }

    public int? CntLargePaychecks { get; set; }

    public int? CntAllPayments { get; set; }

    public int? CntPaperChecks { get; set; }

    public DateOnly? PlannedInvoiceDate { get; set; }

    public DateOnly? ActualInvoiceDate { get; set; }
}
