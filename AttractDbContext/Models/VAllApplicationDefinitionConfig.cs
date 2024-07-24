using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllApplicationDefinitionConfig
{
    public int TemplateId { get; set; }

    public string? TemplateName { get; set; }

    public int TenantId { get; set; }

    public bool? TemplateIsActive { get; set; }

    public int? TemplateDerivedFromTemplateId { get; set; }

    public int TemplateStepId { get; set; }

    public int? TemplateStepOrder { get; set; }

    public string StepName { get; set; } = null!;

    public string UserType { get; set; } = null!;

    public bool? TemplateStepIsActive { get; set; }

    public int TemplateSupStepId { get; set; }

    public string SubStepName { get; set; } = null!;

    public int? TemplateDaysToStale { get; set; }

    public int? TemplateDisplayOrder { get; set; }

    public bool? TemplateSubStepIsActive { get; set; }

    public int? AppDefInstanceId { get; set; }

    public bool? AppDefInstanceIsActive { get; set; }

    public bool? IsApprovedForUse { get; set; }

    public string? ApprovedForUseByUserId { get; set; }

    public DateTime? ApprovedForUseDtutc { get; set; }

    public int? AppDefInstanceStepId { get; set; }

    public int? AppDefInstanceStepOrder { get; set; }

    public bool? AppDefInstanceStepIsActive { get; set; }

    public int? AppDefInstanceSubStepId { get; set; }

    public int? AppDefInstanceSubStepDisplayOrder { get; set; }

    public int? AppDefInstanceSubStepDaysToStale { get; set; }

    public bool? AppDefInstanceSubStepIsActive { get; set; }
}
