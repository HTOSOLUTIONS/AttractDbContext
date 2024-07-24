using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TenantApplicationTemplateSubStep
{
    public int Id { get; set; }

    public int StepId { get; set; }

    public string SubStepName { get; set; } = null!;

    public int? DaysToStale { get; set; }

    public int? DisplayOrder { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }
}
