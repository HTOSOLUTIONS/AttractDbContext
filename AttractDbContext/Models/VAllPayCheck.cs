using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllPayCheck
{
    public int PayCheckId { get; set; }

    public int? BranchEmployeeId { get; set; }

    public string Date { get; set; } = null!;

    public string? EmployeeType { get; set; }

    public string? EmployeeName { get; set; }

    public string? TaxpayerIdEncrypted { get; set; }

    public string? AccountNumber { get; set; }

    public string? RoutingNumber { get; set; }

    public string Void { get; set; } = null!;

    public int? CheckNumber { get; set; }

    public string BankCode { get; set; } = null!;

    public string OfficeCode { get; set; } = null!;

    public string ExternalEmployeeId { get; set; } = null!;

    public string Dbcd { get; set; } = null!;

    public decimal? GrossPay { get; set; }

    public decimal? TotalDeductions { get; set; }

    public decimal? NetPay { get; set; }

    public bool? IsPayCard { get; set; }

    public bool? IsAch { get; set; }

    public bool? IsPaperCheck { get; set; }

    public string? Ssnmasked { get; set; }

    public bool? IsActive { get; set; }

    public int? BranchPayPeriodId { get; set; }

    public int? BranchId { get; set; }

    public int TenantId { get; set; }

    public int? ParentTenantId { get; set; }

    public bool? PayPeriodisAdHoc { get; set; }

    public bool? PayPeriodisInitiated { get; set; }

    public DateTime? PayPeriodInitiatedDt { get; set; }

    public string? PayPeriodInitiatedByUserId { get; set; }

    public bool? PayPeriodisSubmitted { get; set; }

    public string? PayPeriodSubmittedByUserId { get; set; }

    public DateTime? PayPeriodSubmittedDt { get; set; }

    public bool? PayPeriodisApproved { get; set; }

    public string? PayPeriodApprovedByUserId { get; set; }

    public DateTime? PayPeriodApprovedDt { get; set; }

    public bool? PayPeriodPaychecksDrafted { get; set; }

    public bool? PayPeriodPaychecksFinalized { get; set; }

    public bool? PayPeriodPositivePayFinalized { get; set; }

    public bool? PayPeriodPaystubsGenerated { get; set; }

    public bool? PayPeriodAchsubmitted { get; set; }

    public bool? PayPeriodPaycardSubmitted { get; set; }

    public DateOnly? PaychecksFinalizedDt { get; set; }

    public bool? PayPeriodhasBeenRejected { get; set; }

    public bool? IsDraft { get; set; }

    public bool? DoNotPay { get; set; }

    public DateOnly? PayDate { get; set; }
}
