using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VCustomer
{
    public int CustomerId { get; set; }

    public string? TenantName { get; set; }

    public int TenantId { get; set; }

    public int BranchId { get; set; }

    public string? BranchName { get; set; }

    public string? BranchIdent { get; set; }

    public string? BranchEin { get; set; }

    public bool? IsClientRelationshipActive { get; set; }
}
