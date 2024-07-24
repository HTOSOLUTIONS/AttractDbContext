using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup 
/// </summary>
public partial class VtEmployeeTerminationReason
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public bool? IsActive { get; set; }

    public string? DisplayName { get; set; }
}
