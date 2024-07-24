using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class PayrollCheckSummary
{
    public int Id { get; set; }

    public int? PayPeriodId { get; set; }

    public int? BranchId { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpTaxId { get; set; }

    public int? EmployeeId { get; set; }

    public int? PayMethod { get; set; }

    public string? ToRoutingNum { get; set; }

    public string? ToAccountNum { get; set; }

    public string? FromRoutingNum { get; set; }

    public string? FromAccountNum { get; set; }

    public decimal? GrossPay { get; set; }

    public decimal? Fica { get; set; }

    public decimal? Erfica { get; set; }

    public decimal? Fit { get; set; }

    public decimal? Futa { get; set; }

    public decimal? Sit { get; set; }

    public decimal? Suta { get; set; }

    public decimal? Deductions { get; set; }

    public decimal? Garnishments { get; set; }

    public decimal? NetPay { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? CheckStatus { get; set; }

    public bool? AchreplacedWithPaperCheck { get; set; }

    public bool? IsJournaled { get; set; }

    public DateTime? JournaledDt { get; set; }

    public int? CheckNumber { get; set; }

    public int? PaycheckId { get; set; }

    public int? CheckDocumentId { get; set; }

    public bool? PosPayDownloaded { get; set; }

    public DateTime? PosPayDownloadDt { get; set; }

    public string? PosPayDownloadedByUserId { get; set; }

    public bool? Achdownloaded { get; set; }

    public DateTime? AchdownloadDt { get; set; }

    public string? AchdownloadedByUserId { get; set; }
}
