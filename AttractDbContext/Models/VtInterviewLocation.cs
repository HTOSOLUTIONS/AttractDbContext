using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VtInterviewLocation
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public string? LookupValue { get; set; }

    public bool? IsActive { get; set; }
}
