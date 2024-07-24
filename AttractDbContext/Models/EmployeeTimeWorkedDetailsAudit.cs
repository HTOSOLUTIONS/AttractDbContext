using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// audit trail of updates and movements, specific to timeworkeddetail 
/// </summary>
public partial class EmployeeTimeWorkedDetailsAudit
{
    public int Id { get; set; }

    public int? DetailId { get; set; }

    public int? TimeWorkedShiftId { get; set; }

    public DateTime? DetailStartTime { get; set; }

    public DateTime? DetailEndTime { get; set; }

    public bool? IsRegRate { get; set; }

    public bool? IsOtrate { get; set; }

    public bool? IsDoubleRate { get; set; }

    public bool? IsBreak { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public string? Dmltype { get; set; }
}
