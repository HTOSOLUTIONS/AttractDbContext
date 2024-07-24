using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllUsersWithRole
{
    public string UserId { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public string? Auth0UserKey { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public bool? UseraccountIsActive { get; set; }

    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public string? ClientName { get; set; }

    public bool? UserroleIsActive { get; set; }

    public int? BranchId { get; set; }
}
