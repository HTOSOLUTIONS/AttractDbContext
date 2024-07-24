using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Assigns an employee to the job order and jobsite - note: The data is independent of the job order. Will handle population of this upon create with an SP. 
/// </summary>
public partial class BranchEmployeeAssignment
{
    public int Id { get; set; }

    public int? JobOrderId { get; set; }

    public int? BranchEmployeeId { get; set; }

    public DateOnly? AssignmentDate { get; set; }

    public DateOnly? ServiceBeginDate { get; set; }

    public DateOnly? ServiceEndDate { get; set; }

    public string? SupervisorName { get; set; }

    public string? DepartmentName { get; set; }

    public string? RecruiterId { get; set; }

    public string? SalespersonId { get; set; }

    public string? JobTitle { get; set; }

    public string? ContractNumber { get; set; }

    public string? PointofContactName { get; set; }

    public string? JobOrderDescription { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public decimal? LimitDollars { get; set; }

    public decimal? LimitHours { get; set; }

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

    public bool? WorkShiftSun { get; set; }

    public bool? WorkShiftMon { get; set; }

    public bool? WorkShiftTue { get; set; }

    public bool? WorkShiftWed { get; set; }

    public bool? WorkShiftThu { get; set; }

    public bool? WorkShiftFri { get; set; }

    public bool? WorkShiftSat { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public int? JobSiteId { get; set; }

    public bool? IsActive { get; set; }

    public int? JobOrderShiftScheduleId { get; set; }

    public int? AssignmentTerminationReasonId { get; set; }

    public DateTime? AssignmentTerminationDt { get; set; }

    public virtual BranchEmployee? BranchEmployee { get; set; }

    public virtual ICollection<BranchEmployeeAssignmentRate> BranchEmployeeAssignmentRates { get; set; } = new List<BranchEmployeeAssignmentRate>();

    public virtual ICollection<EmployeeTimeWorkedShift> EmployeeTimeWorkedShifts { get; set; } = new List<EmployeeTimeWorkedShift>();

    public virtual BranchJobOrder? JobOrder { get; set; }

    public virtual ClientJobSite? JobSite { get; set; }

    public virtual ICollection<PayChecksPay> PayChecksPays { get; set; } = new List<PayChecksPay>();
}
