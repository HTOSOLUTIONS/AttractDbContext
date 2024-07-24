using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VTimeCardsDaily
{
    public int BranchEmployeeId { get; set; }

    public int TalentId { get; set; }

    public DateOnly? WorkedDate { get; set; }

    public decimal? WorkedHrs { get; set; }

    public decimal? EffectivePayRate { get; set; }

    public decimal? EffectiveBillRate { get; set; }

    public string? EffectivePayType { get; set; }

    public decimal? TotalPay { get; set; }

    public decimal? TotalBillable { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsApproved { get; set; }

    public int BranchEmployeeAssignmentId { get; set; }

    public int TenantBranchId { get; set; }

    public int ClientJobSiteId { get; set; }

    public int BranchClientId { get; set; }

    public int TenantId { get; set; }

    public int? EffectivePayTypeId { get; set; }

    public int DetailsId { get; set; }

    public int? EmployeeTimeCardId { get; set; }

    public bool IsLocked { get; set; }

    public int EmployeeTimeWorkedShiftId { get; set; }
}
