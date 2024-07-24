using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// All deductions recorded for a paycheck 
/// </summary>
public partial class PayChecksDeduction
{
    public int Id { get; set; }

    public int? PayCheckId { get; set; }

    public int? DeductionType { get; set; }

    public decimal? Amount { get; set; }

    public bool? IsPreTax { get; set; }

    public string? Descrip { get; set; }

    public DateTime? CreatedOnUtcdt { get; set; }

    public DateTime? ModifiedUtcdt { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public bool? IsActive { get; set; }

    public int? EmployeeDeductionInstanceId { get; set; }

    public virtual VtPayrollDeductionTypesBranchAssoc? DeductionTypeNavigation { get; set; }

    public virtual PayCheck? PayCheck { get; set; }
}
