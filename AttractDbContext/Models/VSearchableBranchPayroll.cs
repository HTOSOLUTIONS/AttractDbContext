using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VSearchableBranchPayroll
{
    public int? BranchId { get; set; }

    public string? BranchName { get; set; }

    public string? BranchNameRev { get; set; }

    public int PayPeriodId { get; set; }

    public string? TheYear { get; set; }

    public string? TheMonthName { get; set; }

    public int? TenantId { get; set; }

    public string? Mmyyyy { get; set; }

    public string? Style101 { get; set; }

    public string? Style112 { get; set; }

    public string? Style120 { get; set; }
}
