using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup 
/// </summary>
public partial class VtJobOrderApplicationSubStep
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public string? LookupValue { get; set; }

    public bool? IsActive { get; set; }

    public int? ApplicationStepId { get; set; }

    public string? UserType { get; set; }

    public int? DaysUntilStale { get; set; }

    public int? SubStepOrder { get; set; }
}
