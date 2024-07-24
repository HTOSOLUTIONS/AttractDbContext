using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Instance of a paycheck for an employee 
/// </summary>
public partial class PayCheck
{
    public int Id { get; set; }

    public int? BranchEmployeeId { get; set; }

    public int? BranchPayPeriodId { get; set; }

    public bool? IsPayCard { get; set; }

    public bool? IsAch { get; set; }

    public bool? IsPaperCheck { get; set; }

    public string? Ssnmasked { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOnUtcdt { get; set; }

    public DateTime? ModifiedUtcdt { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public bool? IsDraft { get; set; }

    public bool? DoNotPay { get; set; }

    public int? CheckNumber { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidedDtutc { get; set; }

    public string? VoidedByUserId { get; set; }

    public int? VoidReplacedByPaycheckId { get; set; }

    public int? VoidReason { get; set; }

    public string? VoidDescription { get; set; }

    public virtual BranchEmployee? BranchEmployee { get; set; }

    public virtual BranchPayPeriod? BranchPayPeriod { get; set; }

    public virtual ICollection<EmployeeTimeCard> EmployeeTimeCards { get; set; } = new List<EmployeeTimeCard>();

    public virtual ICollection<PayCheckFinalPayDetail> PayCheckFinalPayDetails { get; set; } = new List<PayCheckFinalPayDetail>();

    public virtual ICollection<PayChecksDeduction> PayChecksDeductions { get; set; } = new List<PayChecksDeduction>();

    public virtual ICollection<PayChecksPay> PayChecksPays { get; set; } = new List<PayChecksPay>();

    public virtual ICollection<TaxCompensation> TaxCompensations { get; set; } = new List<TaxCompensation>();

    public virtual ICollection<TaxFormDatum> TaxFormData { get; set; } = new List<TaxFormDatum>();

    public virtual ICollection<TaxTaxis> TaxTaxes { get; set; } = new List<TaxTaxis>();

    public virtual ICollection<TaxVersion> TaxVersions { get; set; } = new List<TaxVersion>();
}
