using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Creates queryable synonyms for skills so that talent can be queried in a variety of skills-related ways. 
/// </summary>
public partial class VtSkillSynonym
{
    public int Id { get; set; }

    public int? SkillId { get; set; }

    public string? SynonymText { get; set; }

    public virtual VtSkill? Skill { get; set; }
}
