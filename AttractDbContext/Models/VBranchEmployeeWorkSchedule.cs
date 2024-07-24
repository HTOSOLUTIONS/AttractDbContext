using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VBranchEmployeeWorkSchedule
{
    public int? BranchEmployeeId { get; set; }

    public int TalentId { get; set; }

    public string? EmployeeName { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public int? AssignmentId { get; set; }

    public DateOnly? WorkDate { get; set; }

    public decimal? Duration { get; set; }

    public int? BranchId { get; set; }

    public int AssignmentBranchClientId { get; set; }

    public string? AssignmentClientName { get; set; }

    public int JobOrderId { get; set; }

    public bool? AssignmentIsActive { get; set; }

    public string EmploymentStatus { get; set; } = null!;

    public DateTime? AssignmentTerminationDt { get; set; }

    public int? AssignmentTerminationReasonId { get; set; }

    public int? EmploymentTerminationReasonId { get; set; }

    public DateTime? EmploymentTerminationDate { get; set; }

    public string? AssignmentName { get; set; }

    public string? JobOrderJobTitle { get; set; }

    public int JobOrderJobSiteId { get; set; }

    public string? JobOrderJobSiteName { get; set; }

    public bool? IsInternalClient { get; set; }

    public int ShiftDefId { get; set; }

    public string? ShiftName { get; set; }
}
