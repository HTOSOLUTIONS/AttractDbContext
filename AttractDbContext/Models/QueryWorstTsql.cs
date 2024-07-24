using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// used for performance analysis during development. not for production.  
/// </summary>
public partial class QueryWorstTsql
{
    public string? DatabaseName { get; set; }

    public string? Statement { get; set; }

    public string? SchemaName { get; set; }

    public string? ObjectName { get; set; }

    public string CachedPlanObjtype { get; set; } = null!;

    public long ExecutionCount { get; set; }

    public long? AvgElapsedTime { get; set; }

    public long? TotalElaspedTime { get; set; }

    public DateTime LastExecutionTime { get; set; }

    public long? AverageIos { get; set; }

    public long? TotalIos { get; set; }

    public long? AvgLogicalReads { get; set; }

    public long TotalLogicalReads { get; set; }

    public long? AvgLogicalWrites { get; set; }

    public long TotalLogicalWrites { get; set; }

    public long? AvgPhysicalReads { get; set; }

    public long TotalPhysicalReads { get; set; }

    public long? AvgCpu { get; set; }

    public long TotalCpu { get; set; }
}
