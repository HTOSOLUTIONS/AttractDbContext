using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup  
/// </summary>
public partial class VtSkill
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public string? LookupValue { get; set; }

    public bool? IsActive { get; set; }

    public string? SkillIdent { get; set; }

    public string? WorkersCompSkillTypeIdent { get; set; }

    public virtual ICollection<BranchJobOrderSkill> BranchJobOrderSkills { get; set; } = new List<BranchJobOrderSkill>();

    public virtual ICollection<JobOrderSkillsNeeded> JobOrderSkillsNeededs { get; set; } = new List<JobOrderSkillsNeeded>();

    public virtual ICollection<SkillGroup> SkillGroups { get; set; } = new List<SkillGroup>();

    public virtual ICollection<TalentSkill> TalentSkills { get; set; } = new List<TalentSkill>();

    public virtual ICollection<VtSkillSynonym> VtSkillSynonyms { get; set; } = new List<VtSkillSynonym>();
}
