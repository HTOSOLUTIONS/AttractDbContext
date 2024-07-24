using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentApplicationJobOrderShift
{
    public int Id { get; set; }

    public int TalentId { get; set; }

    public int JobOrderId { get; set; }

    public int ApplicationInstanceId { get; set; }

    public int ShiftScheduleId { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public virtual TalentJobOrderApplicationInstance ApplicationInstance { get; set; } = null!;

    public virtual BranchJobOrder JobOrder { get; set; } = null!;

    public virtual BranchJobOrderShiftSchedule ShiftSchedule { get; set; } = null!;

    public virtual Talent Talent { get; set; } = null!;
}
