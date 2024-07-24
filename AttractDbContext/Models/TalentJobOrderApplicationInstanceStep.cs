using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentJobOrderApplicationInstanceStep
{
    public int Id { get; set; }

    public int TalentJobOrderApplicationInstanceId { get; set; }

    public bool? IsStale { get; set; }

    public bool? IsComplete { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public int? AppDefInstanceStepId { get; set; }

    public DateTime? CompletedDt { get; set; }

    public string? CompletedByUserId { get; set; }
}
