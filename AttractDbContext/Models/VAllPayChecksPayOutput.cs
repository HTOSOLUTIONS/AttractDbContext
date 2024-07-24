using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllPayChecksPayOutput
{
    public int? EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public int? CheckNumber { get; set; }

    public decimal? Amount { get; set; }

    public DateOnly? PayDate { get; set; }

    public string? PayFromRoutingNumberEncrypted { get; set; }

    public string? PayFromAccountEncrypted { get; set; }

    public string? AchpayToAccountNumberEncrypted { get; set; }

    public string? AchpayToRoutingNumberEncrypted { get; set; }

    public bool? IsAch { get; set; }

    public bool? IsPaperCheck { get; set; }

    public bool? IsPayCard { get; set; }

    public bool? IsActive { get; set; }

    public int? BranchPayPeriodId { get; set; }

    public DateTime? SubmittedDt { get; set; }

    public DateOnly? PeriodStartDt { get; set; }

    public DateOnly? PeriodEndDt { get; set; }

    public string? TaxpayerIdEncrypted { get; set; }

    public string? BranchName { get; set; }
}
