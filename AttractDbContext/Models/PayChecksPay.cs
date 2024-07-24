using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// All pay items for a paycheck 
/// </summary>
public partial class PayChecksPay
{
    public int Id { get; set; }

    public int? PayCheckId { get; set; }

    public int? PayType { get; set; }

    public decimal? UnitAmount { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? TotalAmount { get; set; }

    public bool? IsTaxable { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOnUtcdt { get; set; }

    public DateTime? ModifiedUtcdt { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public int? BillableToBranchClientId { get; set; }

    public string? Descrip { get; set; }

    public int? BillableToBranchAssignmentId { get; set; }

    public string? ShiftName { get; set; }

    public string? ShiftScheduleDays { get; set; }

    public TimeOnly? ShiftScheduleBeginTime { get; set; }

    public decimal? ShiftScheduleShiftduration { get; set; }

    public decimal? AddlPayBillTotal { get; set; }

    public virtual BranchEmployeeAssignment? BillableToBranchAssignment { get; set; }

    public virtual PayCheck? PayCheck { get; set; }

    public virtual VtPayrollPayType? PayTypeNavigation { get; set; }
}
