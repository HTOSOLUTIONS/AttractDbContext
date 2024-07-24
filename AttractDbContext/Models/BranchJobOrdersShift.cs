using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Associates Job Order to Shift.  
/// </summary>
public partial class BranchJobOrdersShift
{
    public int Id { get; set; }

    public int? JobOrderId { get; set; }

    public int? ShiftDefinitionId { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public virtual ICollection<BranchJobOrderShiftSchedule> BranchJobOrderShiftSchedules { get; set; } = new List<BranchJobOrderShiftSchedule>();
}
