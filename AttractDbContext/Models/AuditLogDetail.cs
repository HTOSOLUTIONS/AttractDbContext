using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Stores details about any update to data being audited.  
/// </summary>
public partial class AuditLogDetail
{
    public decimal Id { get; set; }

    public decimal Headerid { get; set; }

    public string ColumnName { get; set; } = null!;

    public string? ColumnOldValue { get; set; }

    public string? ColumnNewValue { get; set; }

    public virtual AuditLogHeader Header { get; set; } = null!;
}
