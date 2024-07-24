using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllUserComponentClaim
{
    public string? UserId { get; set; }

    public int? TenantId { get; set; }

    public int? UserRoleId { get; set; }

    public bool? UserRoleIsActive { get; set; }

    public int? BranchId { get; set; }

    public int? RegionId { get; set; }

    public int? ComponentId { get; set; }

    public string? ComponentKey { get; set; }

    public string? GroupName { get; set; }

    public string? RoleName { get; set; }

    public bool? IsSupported { get; set; }
}
