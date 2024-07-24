using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Associates a branch with talent upon employment 
/// </summary>
public partial class BranchEmployee
{
    public int Id { get; set; }

    public int? TalentId { get; set; }

    public int? TenantBranchId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public string? ExternalEmployeeId { get; set; }

    public DateTime? HireDate { get; set; }

    public DateTime? TerminationDate { get; set; }

    public bool? IsActive { get; set; }

    public int? TerminationReasonId { get; set; }

    public DateOnly? PayThroughDate { get; set; }

    public bool? EligibleForRehire { get; set; }

    public string? RehireEligibilityNote { get; set; }

    public int? EmployeeTypeId { get; set; }

    public string? StaffJobTitle { get; set; }

    public virtual ICollection<BranchEmployeeAssignment> BranchEmployeeAssignments { get; set; } = new List<BranchEmployeeAssignment>();

    public virtual ICollection<BranchEmployeeClientSubmission> BranchEmployeeClientSubmissions { get; set; } = new List<BranchEmployeeClientSubmission>();

    public virtual ICollection<BranchEmployeeDeductionInstance> BranchEmployeeDeductionInstances { get; set; } = new List<BranchEmployeeDeductionInstance>();

    public virtual ICollection<BranchEmployeePayAllocation> BranchEmployeePayAllocations { get; set; } = new List<BranchEmployeePayAllocation>();

    public virtual ICollection<BranchEmployeePaycheckPreference> BranchEmployeePaycheckPreferences { get; set; } = new List<BranchEmployeePaycheckPreference>();

    public virtual ICollection<BranchEmployeeTaxSetupPoc> BranchEmployeeTaxSetupPocs { get; set; } = new List<BranchEmployeeTaxSetupPoc>();

    public virtual ICollection<BranchEmployeeWage> BranchEmployeeWages { get; set; } = new List<BranchEmployeeWage>();

    public virtual ICollection<EmployeeTimeCard> EmployeeTimeCards { get; set; } = new List<EmployeeTimeCard>();

    public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

    public virtual ICollection<PayCheckFinalPayDetail> PayCheckFinalPayDetails { get; set; } = new List<PayCheckFinalPayDetail>();

    public virtual ICollection<PayCheck> PayChecks { get; set; } = new List<PayCheck>();

    public virtual Talent? Talent { get; set; }

    public virtual ICollection<TalentApplicationStatement> TalentApplicationStatements { get; set; } = new List<TalentApplicationStatement>();

    public virtual ICollection<TaxCompensation> TaxCompensations { get; set; } = new List<TaxCompensation>();

    public virtual ICollection<TaxFormDatum> TaxFormData { get; set; } = new List<TaxFormDatum>();

    public virtual ICollection<TaxTaxis> TaxTaxes { get; set; } = new List<TaxTaxis>();

    public virtual ICollection<TaxVersion> TaxVersions { get; set; } = new List<TaxVersion>();

    public virtual TenantBranch? TenantBranch { get; set; }
}
