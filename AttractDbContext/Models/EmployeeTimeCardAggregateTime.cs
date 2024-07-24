using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class EmployeeTimeCardAggregateTime
{
    public int Id { get; set; }

    public int? TimecardId { get; set; }

    public int? AssignmentId { get; set; }

    public int? RateId { get; set; }

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

    public decimal? HoursReg { get; set; }

    public decimal? HoursOt { get; set; }

    public decimal? HoursDt { get; set; }

    public string? DataSource { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }
}
