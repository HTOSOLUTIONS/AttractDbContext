using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllTalentApplicationInstance
{
    public int TalentAppId { get; set; }

    public int TalentAppStepId { get; set; }

    public int TalentAppSubStepId { get; set; }

    public int ApplicationDefInstanceId { get; set; }

    public bool? AppIsStale { get; set; }

    public bool? AppIsComplete { get; set; }

    public bool? AppIsActive { get; set; }

    public int? TalentId { get; set; }

    public int? JobOrderId { get; set; }

    public int TalentJobOrderApplicationInstanceId { get; set; }

    public bool? StepIsStale { get; set; }

    public bool? StepIsComplete { get; set; }

    public bool? StepIsActive { get; set; }

    public int? AppDefInstanceStepId { get; set; }

    public int TalentJobOrderApplicationInstanceStepId { get; set; }

    public bool? SubStepIsStale { get; set; }

    public int DerivedSubStepIsStale { get; set; }

    public bool? SubStepIsComplete { get; set; }

    public bool? SubStepIsActive { get; set; }

    public int? AppDefInstanceSubStepId { get; set; }

    public int TemplateId { get; set; }

    public string? TemplateName { get; set; }

    public int TenantId { get; set; }

    public string StepName { get; set; } = null!;

    public string UserType { get; set; } = null!;

    public string SubStepName { get; set; } = null!;

    public int? AppDefInstanceSubStepDaysToStale { get; set; }

    public int? TemplateDaysToStale { get; set; }

    public DateTime? SubStepCompleteDt { get; set; }

    public string? SubStepCompletedByUserId { get; set; }

    public DateTime? StepCompleteDt { get; set; }

    public string? StepCompletedByUserId { get; set; }

    public int? StepOrder { get; set; }
}
