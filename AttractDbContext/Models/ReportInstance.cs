using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class ReportInstance
{
    public int Id { get; set; }

    public string? UserReportName { get; set; }

    public int? ReportTypeId { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? FilePath { get; set; }

    public bool? IsActive { get; set; }

    public string? Params { get; set; }

    public string? ReportStatus { get; set; }

    public string? WorkflowId { get; set; }

    public int? DocumentId { get; set; }
}
