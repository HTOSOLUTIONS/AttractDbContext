using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup  
/// </summary>
public partial class VtPayrollDeductionTypesBranchAssoc
{
    public int Id { get; set; }

    public int? DeductionTypeId { get; set; }

    public int? BranchId { get; set; }

    public bool? IsActive { get; set; }

    public string? DeductionTypeAlias { get; set; }

    public int? BasePriority { get; set; }

    public string? LongDescription { get; set; }

    public int? GroupId { get; set; }

    public int? DeductionMethodId { get; set; }

    public decimal? DefaultPct { get; set; }

    public decimal? DefaultLimit { get; set; }

    public int? GlaccountId { get; set; }

    public string? W2code { get; set; }

    public bool? ResetBalance { get; set; }

    public bool? IsPretaxFederal { get; set; }

    public bool? IsPretaxFica { get; set; }

    public bool? IsPretaxState { get; set; }

    public bool? IsPretaxLocal { get; set; }

    public bool? IsNondiscretionary { get; set; }

    public bool? IsPreTax { get; set; }

    public string? Payer { get; set; }

    public virtual TenantBranch? Branch { get; set; }

    public virtual ICollection<BranchEmployeeDeductionInstance> BranchEmployeeDeductionInstances { get; set; } = new List<BranchEmployeeDeductionInstance>();

    public virtual VtPayrollDeductionType? DeductionType { get; set; }

    public virtual ICollection<PayChecksDeduction> PayChecksDeductions { get; set; } = new List<PayChecksDeduction>();
}
