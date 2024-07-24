using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// IN PROGRESS 
/// </summary>
public partial class TaxVersion
{
    public int Id { get; set; }

    public int? BranchEmployeeId { get; set; }

    public int? PayPeriodId { get; set; }

    public string? Version { get; set; }

    public string? LegacyVersion { get; set; }

    public string? DataVersion { get; set; }

    public int? PayCheckId { get; set; }

    public virtual BranchEmployee? BranchEmployee { get; set; }

    public virtual PayCheck? PayCheck { get; set; }

    public virtual BranchPayPeriod? PayPeriod { get; set; }
}
