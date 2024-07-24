using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class AssignCache
{
    public int? Employeeid { get; set; }

    public int? Assignid { get; set; }

    public int? Joborderid { get; set; }

    public int? Shiftschedid { get; set; }

    public DateTime? Startdt { get; set; }
}
