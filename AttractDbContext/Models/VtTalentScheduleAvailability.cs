using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VtTalentScheduleAvailability
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public bool? IsActive { get; set; }

    public string? DisplayName { get; set; }
}
