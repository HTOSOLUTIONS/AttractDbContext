using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TenantApplicationTemplateStep
{
    public int Id { get; set; }

    public int? StepOrder { get; set; }

    public string StepName { get; set; } = null!;

    public string UserType { get; set; } = null!;

    public bool? IsActive { get; set; }

    public int TemplateId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }
}
