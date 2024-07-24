using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Stores references back to the original source data being updated/inserted/deleted.  
/// </summary>
public partial class AuditLogTablePrimaryKey
{
    public decimal Id { get; set; }

    public string TableSchema { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public string PrimaryKeyColumnName { get; set; } = null!;
}
