using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchEmployeeTimeOffPlan
{
    public int Id { get; set; }

    public int? BranchEmployeeId { get; set; }

    public int? TimeOffPlanId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateOnly? PlanEffectiveDate { get; set; }

    public DateOnly? PlanEndDate { get; set; }
}
