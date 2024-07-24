using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class ApplicationDefInstanceStep
{
    public int Id { get; set; }

    public int? InstanceId { get; set; }

    public int TemplateStepId { get; set; }

    public int? StepOrder { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }
}
