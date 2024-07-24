using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VBranchTimeOffConfig
{
    public int TotypeId { get; set; }

    public int? BranchId { get; set; }

    public string? TimeOffTypeName { get; set; }

    public bool? TotypeIsActive { get; set; }

    public int? ToplanId { get; set; }

    public int? BranchTimeOffTypeId { get; set; }

    public string? PlanName { get; set; }

    public string? PlanDescription { get; set; }

    public bool? IsUnlimited { get; set; }

    public decimal? HoursAccrued { get; set; }

    public int? AccrualFrequency { get; set; }

    public decimal? CapAccrualHours { get; set; }

    public int? PlanRenewalMonth { get; set; }

    public int? PlanRenewalDay { get; set; }

    public bool? ProrateTimeOff { get; set; }

    public bool? AllowCarryover { get; set; }

    public decimal? MaxCarryoverHours { get; set; }

    public int? UnusedCarryoverExpirationMonth { get; set; }

    public int? UnusedCarryoverExpirationDay { get; set; }

    public bool? NegativeBalanceCarryover { get; set; }

    public decimal? MaxNegativeCarryover { get; set; }

    public decimal? ProbationaryPeriodMonths { get; set; }

    public bool? AllowNegativeRequests { get; set; }

    public bool? DefaultAllEmployees { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public bool? ToplanIsActive { get; set; }

    public decimal? AccruePerHoursWorked { get; set; }

    public string? AccrualFrequencyName { get; set; }

    public int? AccrualFrequencyDaysCovered { get; set; }
}
