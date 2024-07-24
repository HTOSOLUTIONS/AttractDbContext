using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchEmployeeAssignmentWorkSchedule
{
    public int Id { get; set; }

    public int? BranchEmployeeId { get; set; }

    public int? AssignmentId { get; set; }

    public int? ShiftScheduleId { get; set; }

    public DateOnly? WorkDate { get; set; }

    public decimal? Duration { get; set; }

    public int? BranchId { get; set; }
}
