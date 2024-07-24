using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VSearchableTenant
{
    public int TenantId { get; set; }

    public string? TenantName { get; set; }

    public string? BranchName { get; set; }

    public string? BranchCity { get; set; }

    public string? BranchZipCode { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public int BranchId { get; set; }
}
