using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Pay Periods - pay date, start/end, etc. for a given branch.  
/// </summary>
public partial class BranchPayPeriod
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? TemplateId { get; set; }

    public DateOnly? PayDate { get; set; }

    public DateOnly? PeriodStartDt { get; set; }

    public DateOnly? PeriodEndDt { get; set; }

    public DateOnly? PayrollDueDate { get; set; }

    public bool? IsPaid { get; set; }

    public DateTime? CreatedOnUtcdt { get; set; }

    public DateTime? ModifiedUtcdt { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsAdHoc { get; set; }

    public bool? IsInitiated { get; set; }

    public DateTime? InitiatedDt { get; set; }

    public string? InitiatedByUserId { get; set; }

    public bool? IsSubmitted { get; set; }

    public DateTime? SubmittedDt { get; set; }

    public string? SubmittedByUserId { get; set; }

    public bool? IsApproved { get; set; }

    public string? ApprovedByUserId { get; set; }

    public DateTime? ApprovedDt { get; set; }

    public bool? PaychecksDrafted { get; set; }

    public bool? PaychecksFinalized { get; set; }

    public bool? PositivePayFinalized { get; set; }

    public bool? PaystubsGenerated { get; set; }

    public bool? Achsubmitted { get; set; }

    public bool? PaycardSubmitted { get; set; }

    public bool? IsRejected { get; set; }

    public string? RejectedByUserId { get; set; }

    public DateTime? RejectedDt { get; set; }

    public string? PaychecksDraftedByUserId { get; set; }

    public DateOnly? PaychecksDraftedDt { get; set; }

    public string? PaychecksFinalizedByUserId { get; set; }

    public DateOnly? PaychecksFinalizedDt { get; set; }

    public bool? IsManual { get; set; }

    public bool? LimitPayeesToTimecards { get; set; }

    public DateOnly? PlannedInvoiceDate { get; set; }

    public DateOnly? ActualInvoiceDate { get; set; }

    public int? FullCheckDocumentId { get; set; }

    public string? CheckPrintStatus { get; set; }

    public int? FullCheckPreviewDocId { get; set; }

    public virtual ICollection<EmployeeTimeCard> EmployeeTimeCards { get; set; } = new List<EmployeeTimeCard>();

    public virtual ICollection<PayCheck> PayChecks { get; set; } = new List<PayCheck>();

    public virtual ICollection<TaxCompensation> TaxCompensations { get; set; } = new List<TaxCompensation>();

    public virtual ICollection<TaxFormDatum> TaxFormData { get; set; } = new List<TaxFormDatum>();

    public virtual ICollection<TaxTaxis> TaxTaxes { get; set; } = new List<TaxTaxis>();

    public virtual ICollection<TaxVersion> TaxVersions { get; set; } = new List<TaxVersion>();

    public virtual BranchPayPeriodTemplate? Template { get; set; }
}
