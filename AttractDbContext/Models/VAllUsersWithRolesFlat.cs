using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllUsersWithRolesFlat
{
    public string UserId { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public string? Auth0UserKey { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public bool? UserAccountIsActive { get; set; }

    public string? Roles { get; set; }

    public string? TenantName { get; set; }

    public int TenantId { get; set; }

    public bool? UserroleIsActive { get; set; }

    public int? BranchId { get; set; }

    public string? UserStatus { get; set; }

    public string Token { get; set; } = null!;
}
