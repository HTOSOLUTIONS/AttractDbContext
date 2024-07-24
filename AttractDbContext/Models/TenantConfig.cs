using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Configuration options for tenant site behavior -- Not implemented yet 
/// </summary>
public partial class TenantConfig
{
    public int Id { get; set; }

    public string? ConfigKey { get; set; }

    public string? ConfigValue { get; set; }

    public int? TenantId { get; set; }

    public virtual Tenant? Tenant { get; set; }
}
