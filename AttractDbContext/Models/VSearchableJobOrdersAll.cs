using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VSearchableJobOrdersAll
{
    public int BranchClientId { get; set; }

    public string? BranchClientName { get; set; }

    public string? BranchClientIdent { get; set; }

    public bool? IsActive { get; set; }

    public int? BranchId { get; set; }

    public string? BranchClientNameRev { get; set; }

    public string? JobTitle { get; set; }

    public string? JobTitleRev { get; set; }

    public int JobOrderId { get; set; }
}
