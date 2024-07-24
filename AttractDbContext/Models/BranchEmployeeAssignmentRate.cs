using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchEmployeeAssignmentRate
{
    public int Id { get; set; }

    public int? AssignmentId { get; set; }

    public DateOnly? EffectiveStartDt { get; set; }

    public DateOnly? EffectiveEndDt { get; set; }

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

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public virtual BranchEmployeeAssignment? Assignment { get; set; }
}
