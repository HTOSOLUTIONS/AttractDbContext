using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class PayrollCheckSummaryLog
{
    public int Id { get; set; }

    public int? CheckSummaryId { get; set; }

    public string? CheckStatus { get; set; }

    public DateTime? CreatedDtutc { get; set; }
}
