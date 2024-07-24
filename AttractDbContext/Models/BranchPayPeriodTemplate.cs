using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Provides templates for pay periods, from which we seed the payperiod specifics -- e.g., Every two weeks, with the first pay date  being xx/xx/xx and the first pay period start and end dates being xx/xx/xx and yy/yy/yy
/// </summary>
public partial class BranchPayPeriodTemplate
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? PayCyclePeriodId { get; set; }

    public string? PeriodDefinitionName { get; set; }

    public byte? DeductionPayCycleDeterminDates { get; set; }

    public DateOnly? FirstChkDt { get; set; }

    public DateOnly? FirstPayPeriodEnd { get; set; }

    public int? ChkConfigChkPosition { get; set; }

    public DateOnly? ChkConfigStartDt { get; set; }

    public DateOnly? ChkConfigEndDt { get; set; }

    public bool? ChkConfigShowCompanyName { get; set; }

    public bool? ChkConfigShowCompanyAddress { get; set; }

    public bool? ChkConfigShowEmpAddress { get; set; }

    public int? EmailReminderDays { get; set; }

    public DateTime? CreatedOnUtcdt { get; set; }

    public DateTime? ModifiedUtcdt { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public bool? IsActive { get; set; }

    public int? PayrollDueDaysPrior { get; set; }

    public virtual ICollection<BranchPayPeriod> BranchPayPeriods { get; set; } = new List<BranchPayPeriod>();
}
