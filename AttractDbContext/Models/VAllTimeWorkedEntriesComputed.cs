﻿using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllTimeWorkedEntriesComputed
{
    public int EmployeeTimeWorkedShiftId { get; set; }

    public int EmployeeTimeWorkedDetailsId { get; set; }

    public DateOnly? WorkedDate { get; set; }

    public decimal? WorkedHrs { get; set; }

    public DateTime? DetailStartTime { get; set; }

    public DateTime? DetailEndTime { get; set; }

    public decimal? EffectivePayRate { get; set; }

    public decimal? EffectiveBillRate { get; set; }

    public string? EffectivePayType { get; set; }

    public int? EffectivePayTypeId { get; set; }

    public decimal? PayRatePerDiem { get; set; }

    public decimal? PayRateHealth { get; set; }

    public decimal? BillRatePerDiem { get; set; }

    public decimal? BillRateHealth { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsApproved { get; set; }

    public int BranchEmployeeAssignmentId { get; set; }

    public int BranchEmployeeId { get; set; }

    public int TalentId { get; set; }

    public int TenantBranchId { get; set; }

    public int ClientJobSiteId { get; set; }

    public int BranchClientId { get; set; }

    public int TenantId { get; set; }

    public bool? IsBreak { get; set; }

    public int? EmployeeTimeCardId { get; set; }

    public int? PayPeriodId { get; set; }

    public bool IsLocked { get; set; }
}
