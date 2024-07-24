using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup -- all dimensional data regarding a date 
/// </summary>
public partial class VtDate
{
    public int Id { get; set; }

    public DateOnly? TheDate { get; set; }

    public int? TheDay { get; set; }

    public string? TheDaySuffix { get; set; }

    public string? TheDayName { get; set; }

    public int? TheDayOfWeek { get; set; }

    public byte? TheDayOfWeekInMonth { get; set; }

    public int? TheDayOfYear { get; set; }

    public int IsWeekend { get; set; }

    public int? TheWeek { get; set; }

    public int? TheIsoweek { get; set; }

    public DateOnly? TheFirstOfWeek { get; set; }

    public DateOnly? TheLastOfWeek { get; set; }

    public byte? TheWeekOfMonth { get; set; }

    public int? TheMonth { get; set; }

    public string? TheMonthName { get; set; }

    public DateOnly? TheFirstOfMonth { get; set; }

    public DateOnly? TheLastOfMonth { get; set; }

    public DateOnly? TheFirstOfNextMonth { get; set; }

    public DateOnly? TheLastOfNextMonth { get; set; }

    public int? TheYear { get; set; }

    public int? TheIsoyear { get; set; }

    public DateOnly? TheFirstOfYear { get; set; }

    public DateOnly? TheLastOfYear { get; set; }

    public bool? IsLeapYear { get; set; }

    public int Has53Weeks { get; set; }

    public int Has53Isoweeks { get; set; }

    public string? Mmyyyy { get; set; }

    public string? Style101 { get; set; }

    public string? Style103 { get; set; }

    public string? Style112 { get; set; }

    public string? Style120 { get; set; }

    public int? BiWeekNum { get; set; }

    public string? QuarterName { get; set; }
}
