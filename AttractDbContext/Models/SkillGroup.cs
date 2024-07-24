using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Groups the skills listed in vt_skills into topic-related groups 
/// </summary>
public partial class SkillGroup
{
    public int Id { get; set; }

    public int? SkillId { get; set; }

    public int? SkillsGroupDefId { get; set; }

    public virtual VtSkill? Skill { get; set; }

    public virtual VtSkillsGroupDefinition? SkillsGroupDef { get; set; }
}
