using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchEmployeeTimeOffRequest
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public decimal? HoursRequested { get; set; }

    public DateOnly? DateBegin { get; set; }

    public DateOnly? DateEnd { get; set; }

    public DateTime? RequestedOnDt { get; set; }

    public string? ApprovedByUserId { get; set; }

    public DateTime? ApprovedOnDt { get; set; }

    public int? TimeOffPlanId { get; set; }

    public bool? IsBillable { get; set; }

    public int? BilltoAssignentId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }
}
