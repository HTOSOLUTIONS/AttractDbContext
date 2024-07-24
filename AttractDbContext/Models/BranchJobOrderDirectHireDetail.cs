using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchJobOrderDirectHireDetail
{
    public int Id { get; set; }

    public int? BranchJobOrderId { get; set; }

    public string? PositionName { get; set; }

    public int? WagePeriod { get; set; }

    public decimal? WageAmountPerPeriod { get; set; }

    public int? BillingMethod { get; set; }

    public decimal? FlatFeeAmount { get; set; }

    public decimal? PercentageAmount { get; set; }

    public int? QuantityNeeded { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public string? ShiftName { get; set; }

    public virtual BranchJobOrder? BranchJobOrder { get; set; }

    public virtual VtWagePeriod? WagePeriodNavigation { get; set; }
}
