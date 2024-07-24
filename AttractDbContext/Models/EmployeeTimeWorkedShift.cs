using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Shift information, including pay/bill rates, as existing at the time of beginning a shift.  
/// </summary>
public partial class EmployeeTimeWorkedShift
{
    public int Id { get; set; }

    public int? BranchEmployeeAssignmentId { get; set; }

    public DateOnly? ShiftStartDate { get; set; }

    public DateOnly? ShiftEndDate { get; set; }

    public decimal? PayRateReg { get; set; }

    public decimal? PayRateOt { get; set; }

    public decimal? PayRateDouble { get; set; }

    public decimal? PayRatePerDiem { get; set; }

    public decimal? PayRateHealth { get; set; }

    public decimal? BillRateReg { get; set; }

    public decimal? BillRateOt { get; set; }

    public decimal? BillRateDouble { get; set; }

    public decimal? BillRatePerDiem { get; set; }

    public decimal? BillRateHealth { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsApproved { get; set; }

    public string? ApprovedById { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public int? EmployeeTimeCardId { get; set; }

    public virtual BranchEmployeeAssignment? BranchEmployeeAssignment { get; set; }

    public virtual EmployeeTimeCard? EmployeeTimeCard { get; set; }

    public virtual ICollection<EmployeeTimeWorkedDetail> EmployeeTimeWorkedDetails { get; set; } = new List<EmployeeTimeWorkedDetail>();
}
