using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup -- contains overtime/doubletime rules for all states.  
/// </summary>
public partial class VtStateOvertimeRule
{
    public string? StateId { get; set; }

    public string? DayOtthreshold { get; set; }

    public string? DayDtthreshold { get; set; }

    public string? WeekOtthreshold { get; set; }

    public string? MealRequiredAtHrs { get; set; }

    public string? CountMealBreaks { get; set; }

    public string? MealBreakMinutes { get; set; }

    public string? SeventhDayWageMultiplier { get; set; }

    public decimal? MinWage { get; set; }

    public DateOnly? ValidFromDt { get; set; }

    public DateOnly? ValidToDt { get; set; }

    public bool? IsActive { get; set; }

    public int Id { get; set; }
}
