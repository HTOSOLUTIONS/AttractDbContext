using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VtTimeOffAccrualFrequency
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public int? DaysCovered { get; set; }

    public bool? IsActive { get; set; }

    public int? OrderBy { get; set; }
}
