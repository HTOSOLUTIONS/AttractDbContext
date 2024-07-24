using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentAvailability
{
    public int Id { get; set; }

    public int? TalentId { get; set; }

    public int? DayNumber { get; set; }

    public int? AvailabilityId { get; set; }

    public bool? Shift1 { get; set; }

    public bool? Shift2 { get; set; }

    public bool? Shift3 { get; set; }

    public bool? ShiftFlexible { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public DateOnly? AvailableDate { get; set; }

    public virtual Talent? Talent { get; set; }
}
