using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Associates a Job Order with the BranchJobOrderShift, and specifies workdays. Can be many schedules per job order and shift, depending on the work days.  
/// </summary>
public partial class BranchJobOrderShiftSchedule
{
    public int Id { get; set; }

    public int? BranchJobOrderShiftsId { get; set; }

    public bool? WorkShiftSun { get; set; }

    public bool? WorkShiftMon { get; set; }

    public bool? WorkShiftTue { get; set; }

    public bool? WorkShiftWed { get; set; }

    public bool? WorkShiftThu { get; set; }

    public bool? WorkShiftFri { get; set; }

    public bool? WorkShiftSat { get; set; }

    public int? QuantityNeeded { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public bool? IsActive { get; set; }

    public virtual BranchJobOrdersShift? BranchJobOrderShifts { get; set; }

    public virtual ICollection<TalentApplicationJobOrderShift> TalentApplicationJobOrderShifts { get; set; } = new List<TalentApplicationJobOrderShift>();
}
