using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Stores information about updates to data - specifying who changed data and when. 
/// </summary>
public partial class AuditLogHeader
{
    public decimal Id { get; set; }

    public string TableName { get; set; } = null!;

    public string PrimaryKeyColumnName { get; set; } = null!;

    public string? PrimaryKeyColumnValue { get; set; }

    public string AuditAction { get; set; } = null!;

    public string HostName { get; set; } = null!;

    public string AppName { get; set; } = null!;

    public string AuditUserid { get; set; } = null!;

    public DateTime AuditDatetime { get; set; }

    public virtual ICollection<AuditLogDetail> AuditLogDetails { get; set; } = new List<AuditLogDetail>();
}
