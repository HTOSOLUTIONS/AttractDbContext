using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class ApprolePolicy
{
    public int Id { get; set; }

    public int? AppRoleId { get; set; }

    public string? PolicyName { get; set; }

    public int? TenantId { get; set; }

    public string? Descrip { get; set; }

    public string? PolicyValue { get; set; }

    public int? PolicyValPriority { get; set; }
}
