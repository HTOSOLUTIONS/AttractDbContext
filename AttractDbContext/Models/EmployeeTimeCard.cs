using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Connects employee work to pay periods, and subsequently to a paycheck.  
/// </summary>
public partial class EmployeeTimeCard
{
    public int Id { get; set; }

    public int BranchEmployeeId { get; set; }

    public int? PayPeriodId { get; set; }

    public int? PayCheckId { get; set; }

    public bool? IsVerified { get; set; }

    public DateTime? VerifiedDt { get; set; }

    public string? VerifiedByUserId { get; set; }

    public bool? IsLocked { get; set; }

    public DateTime? LockedDt { get; set; }

    public string? LockedByUserId { get; set; }

    public virtual BranchEmployee BranchEmployee { get; set; } = null!;

    public virtual ICollection<EmployeeTimeWorkedShift> EmployeeTimeWorkedShifts { get; set; } = new List<EmployeeTimeWorkedShift>();

    public virtual PayCheck? PayCheck { get; set; }

    public virtual BranchPayPeriod? PayPeriod { get; set; }
}
