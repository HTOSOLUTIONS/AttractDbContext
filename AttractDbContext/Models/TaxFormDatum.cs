using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// IN PROGRESS 
/// </summary>
public partial class TaxFormDatum
{
    public int Id { get; set; }

    public int? BranchEmployeeId { get; set; }

    public int? PayPeriodId { get; set; }

    public string? TaxIdentifierId { get; set; }

    public string? GeocodeId { get; set; }

    public string? TaxName { get; set; }

    public string? TaxType { get; set; }

    public string? FormFieldIdentifier { get; set; }

    public string? UtilizedFormValue { get; set; }

    public string? FormExists { get; set; }

    public string? FormStatus { get; set; }

    public string? FormDescription { get; set; }

    public int? PayCheckId { get; set; }

    public virtual BranchEmployee? BranchEmployee { get; set; }

    public virtual PayCheck? PayCheck { get; set; }

    public virtual BranchPayPeriod? PayPeriod { get; set; }
}
