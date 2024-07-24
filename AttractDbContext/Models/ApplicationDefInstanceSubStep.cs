using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class ApplicationDefInstanceSubStep
{
    public int Id { get; set; }

    public int TemplateSubStepId { get; set; }

    public int StepId { get; set; }

    public int? DisplayOrder { get; set; }

    public int? DaysToStale { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }
}
