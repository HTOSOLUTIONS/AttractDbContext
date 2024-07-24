using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Defines the working shifts and wage/rate adjustments for those shifts, specific to each client.  
/// </summary>
public partial class BranchClientShiftDefinition
{
    public int Id { get; set; }

    public int? BranchClientId { get; set; }

    public decimal? BillAdjustmentAmount { get; set; }

    public decimal? WageAdjustmentAmount { get; set; }

    public string? ShiftName { get; set; }

    public TimeOnly? ShiftStartTime { get; set; }

    public decimal? ShiftDurationHrs { get; set; }

    public int? ShiftPriority { get; set; }

    public int? ShiftSupervisorContactId { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public decimal? OtbillAdjustmentAmount { get; set; }

    public decimal? DtbillAdjustmentAmount { get; set; }

    public virtual BranchClient? BranchClient { get; set; }
}
