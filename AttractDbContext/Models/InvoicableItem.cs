using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class InvoicableItem
{
    public int Id { get; set; }

    public int? PayPeriodId { get; set; }

    public DateOnly? Paydate { get; set; }

    public DateOnly? PayPeriodStartDt { get; set; }

    public DateOnly? PayPeriodEndDt { get; set; }

    public bool? PayPeriodIsAdHoc { get; set; }

    public int? PaycheckId { get; set; }

    public int? PayCheckPaysId { get; set; }

    public int? EmployeeId { get; set; }

    public string? EmployeeFirstName { get; set; }

    public string? EmployeeLastName { get; set; }

    public int? TalentId { get; set; }

    public int? BranchId { get; set; }

    public int? BillToBranchClientId { get; set; }

    public int? BillToEmployeeAssignmentId { get; set; }

    public int? JobOrderId { get; set; }

    public int? JobSiteId { get; set; }

    public int? PositionId { get; set; }

    public string? PositionName { get; set; }

    public string? ShiftName { get; set; }

    public int? ShiftDefinitionId { get; set; }

    public int? TimeCardId { get; set; }

    public DateOnly? WorkDate { get; set; }

    public DateOnly? WeekendingDate { get; set; }

    public string? SupervisorName { get; set; }

    public string? Descrip { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? PayRate { get; set; }

    public decimal? BillRate { get; set; }

    public decimal? ItemTotalPaid { get; set; }

    public decimal? ItemTotalBilled { get; set; }

    public int? ItemTypeId { get; set; }

    public DateTime? DateSubmitted { get; set; }

    public string? SubmittedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public int? InvoiceId { get; set; }

    public DateTime? InvoiceCreatedDt { get; set; }

    public string? InvoiceCreatedByUserId { get; set; }

    public int? InvoiceItemId { get; set; }

    public bool? IsSubmitted { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDt { get; set; }

    public string? ApprovedByUserId { get; set; }

    public string? OtherDescription { get; set; }

    public decimal? Acapercent { get; set; }

    public decimal? Acaamount { get; set; }
}
