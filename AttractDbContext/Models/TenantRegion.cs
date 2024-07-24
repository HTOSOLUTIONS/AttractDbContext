using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// The regions that a tenant is associated with.  
/// </summary>
public partial class TenantRegion
{
    public int Id { get; set; }

    public string? RegionName { get; set; }

    public int? TenantId { get; set; }

    public bool IsActive { get; set; }

    public virtual Tenant? Tenant { get; set; }
}
