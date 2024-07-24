using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchEmployeeTimeOffAccrual
{
    public int Id { get; set; }

    public int? BranchEmployeeId { get; set; }

    public DateOnly? DateAccrued { get; set; }

    public decimal? Amount { get; set; }

    public int? TimeOffPlanId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public decimal? NewTotalAccrued { get; set; }

    public bool? IsAnnualReset { get; set; }
}
