using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class Jobordercache
{
    public string? Joborderident { get; set; }

    public int? Branchid { get; set; }

    public int? Branchclientid { get; set; }

    public int? Joborderid { get; set; }
}
