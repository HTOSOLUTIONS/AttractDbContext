using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentJobOrderApplicationInstanceSubStep
{
    public int Id { get; set; }

    public int TalentJobOrderApplicationInstanceStepId { get; set; }

    public bool? IsStale { get; set; }

    public bool? IsComplete { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public int? AppDefInstanceSubStepId { get; set; }

    public DateTime? CompletedDt { get; set; }

    public string? CompletedByUserId { get; set; }
}
