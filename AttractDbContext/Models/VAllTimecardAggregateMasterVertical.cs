using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllTimecardAggregateMasterVertical
{
    public decimal? EffectivePayRate { get; set; }

    public decimal? WorkedHrs { get; set; }

    public decimal? TotalPay { get; set; }

    public string EffectivePayType { get; set; } = null!;

    public int EffectivePayTypeId { get; set; }

    public decimal? EffectiveBillRate { get; set; }

    public decimal? TotalBillable { get; set; }

    public int TimeCardAggregateId { get; set; }

    public int PayPeriodId { get; set; }

    public DateOnly? PayDate { get; set; }

    public DateOnly? PeriodStartDt { get; set; }

    public DateOnly? PeriodEndDt { get; set; }

    public bool? IsAdhoc { get; set; }

    public bool? IsManual { get; set; }

    public bool? LimitPayeesToTimecards { get; set; }

    public int BranchEmployeeId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public bool? IsVerified { get; set; }

    public int? PayCheckId { get; set; }

    public DateTime? VerifiedDt { get; set; }

    public bool? IsLocked { get; set; }

    public DateTime? LockedDt { get; set; }

    public int? TimecardId { get; set; }

    public int? AssignmentId { get; set; }

    public int? RateId { get; set; }

    public decimal? PayRateReg { get; set; }

    public decimal? PayRateOt { get; set; }

    public decimal? PayRateDouble { get; set; }

    public decimal? PayRatePerDiem { get; set; }

    public decimal? PayRateHealth { get; set; }

    public decimal? GrossPay { get; set; }

    public decimal? BillRateReg { get; set; }

    public decimal? BillRateOt { get; set; }

    public decimal? BillRateDouble { get; set; }

    public decimal? BillRatePerDiem { get; set; }

    public decimal? BillRateHealth { get; set; }

    public decimal? HoursReg { get; set; }

    public decimal? HoursOt { get; set; }

    public decimal? HoursDt { get; set; }

    public decimal? GrossBill { get; set; }

    public string? DataSource { get; set; }

    public int AssignmentBranchClientId { get; set; }

    public bool? IsInternalClient { get; set; }

    public string? AssignmentClientName { get; set; }

    public int AssignmentJobSiteId { get; set; }

    public string? AssignmentJobSiteName { get; set; }

    public int? AssignmentShiftScheduleId { get; set; }

    public string? AssignmentName { get; set; }

    public int? TenantBranchId { get; set; }

    public int TalentId { get; set; }

    public int EmployeeId { get; set; }
}
