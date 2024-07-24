using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// DEPRECATED/REPLACED 
/// </summary>
public partial class JobOrderSkillsNeeded
{
    public int Id { get; set; }

    public int? JobOrderId { get; set; }

    public int? SkillId { get; set; }

    public int? SkillLevel { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public virtual BranchJobOrder? JobOrder { get; set; }

    public virtual VtSkill? Skill { get; set; }
}
