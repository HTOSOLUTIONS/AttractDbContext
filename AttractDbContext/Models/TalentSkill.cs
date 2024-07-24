using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// The skills associated with the talent.  
/// </summary>
public partial class TalentSkill
{
    public int Id { get; set; }

    public int? TalentId { get; set; }

    public int? SkillId { get; set; }

    public int? SkillLevel { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public bool? SkillCanBeVerified { get; set; }

    public string? RelevantEmploymentHistory { get; set; }

    public string? AdditionalDetails { get; set; }

    public bool? IsActive { get; set; }

    public virtual VtSkill? Skill { get; set; }

    public virtual Talent? Talent { get; set; }
}
