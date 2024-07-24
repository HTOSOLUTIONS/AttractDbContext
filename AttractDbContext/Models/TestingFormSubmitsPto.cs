using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TestingFormSubmitsPto
{
    public string? Assignment { get; set; }

    public string? PtoType { get; set; }

    public string? PtoDate { get; set; }

    public string? PartialShift { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }
}
