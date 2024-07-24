using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VSearchBranchClientsAll
{
    public int BranchClientId { get; set; }

    public string? BranchClientName { get; set; }

    public string? BranchClientIdent { get; set; }

    public bool? IsActive { get; set; }

    public string? SalesPersonName { get; set; }

    public int? BranchId { get; set; }

    public string? BranchClientNameRev { get; set; }
}
