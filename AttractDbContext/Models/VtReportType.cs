using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VtReportType
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public string? LookupValue { get; set; }

    public bool? IsActive { get; set; }

    public string? Category { get; set; }
}
