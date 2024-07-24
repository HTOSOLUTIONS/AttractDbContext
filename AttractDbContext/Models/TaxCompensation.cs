using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// IN PROGRESS 
/// </summary>
public partial class TaxCompensation
{
    public int Id { get; set; }

    public int? BranchEmployeeId { get; set; }

    public int? PayPeriodId { get; set; }

    public int? PayCheckId { get; set; }

    public string? CompensationId { get; set; }

    public string? TaxIdentifierId { get; set; }

    public string? GeocodeId { get; set; }

    public string? UtilizedCompensationId { get; set; }

    public string? TaxName { get; set; }

    public string? TaxType { get; set; }

    public string? TaxingLocationType { get; set; }

    public decimal? TaxableAmount { get; set; }

    public decimal? ExemptAmount { get; set; }

    public string? PayType { get; set; }

    public string? CompensationDescription { get; set; }

    public virtual BranchEmployee? BranchEmployee { get; set; }

    public virtual PayCheck? PayCheck { get; set; }

    public virtual BranchPayPeriod? PayPeriod { get; set; }
}
