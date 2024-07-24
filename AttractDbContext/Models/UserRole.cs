using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Associates users with roles and tenants.  
/// </summary>
public partial class UserRole
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int? TenantId { get; set; }

    public int? ApproleId { get; set; }

    public bool? Isactive { get; set; }

    public int? BranchId { get; set; }

    public int? RegionId { get; set; }

    public virtual AppRole? Approle { get; set; }

    public virtual Tenant? Tenant { get; set; }

    public virtual User? User { get; set; }
}
