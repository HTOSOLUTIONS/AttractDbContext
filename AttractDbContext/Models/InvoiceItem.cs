using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Line items for invoices
/// </summary>
public partial class InvoiceItem
{
    public int Id { get; set; }

    public int? InvoiceId { get; set; }

    public int? BranchEmployeeId { get; set; }

    public string? PositionText { get; set; }

    public string? EmployeeLastName { get; set; }

    public string? EmployeeFirstName { get; set; }

    public DateOnly? WorkDate { get; set; }

    public decimal? Rate { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public string? TimeCardNumber { get; set; }

    public string? DescriptionText { get; set; }

    public string? JobSiteName { get; set; }

    public string? DepartmentName { get; set; }

    public string? ShiftName { get; set; }

    public int? JobOrderId { get; set; }

    public decimal? TaxAmount { get; set; }

    public string? SupervisorName { get; set; }

    public int? GroupTicketId { get; set; }

    public DateOnly? WeekEndingDate { get; set; }

    public int? BranchEmployeeAssignmentId { get; set; }

    public decimal? Quantity { get; set; }

    public int? ItemTypeId { get; set; }

    public decimal? ItemTotal { get; set; }

    public decimal? GrossTotal { get; set; }

    public decimal? Acapercent { get; set; }

    public decimal? Acaamount { get; set; }

    public virtual BranchEmployee? BranchEmployee { get; set; }

    public virtual Invoice? Invoice { get; set; }
}
