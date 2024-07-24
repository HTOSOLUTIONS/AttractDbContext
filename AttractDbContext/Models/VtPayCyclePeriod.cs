using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup  
/// </summary>
public partial class VtPayCyclePeriod
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public bool? IsActive { get; set; }

    public int? LengthDays { get; set; }
}
