using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TbIxMissing
{
    public string? Dbname { get; set; }

    public string Schemaname { get; set; } = null!;

    public string Objectname { get; set; } = null!;

    public double? Impact { get; set; }

    public DateTime? LastUserSeek { get; set; }

    public string? CreateIndexStatement { get; set; }

    public string? EqualityColumns { get; set; }

    public string? InequalityColumns { get; set; }

    public string? IncludedColumns { get; set; }
}
