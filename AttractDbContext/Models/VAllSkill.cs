using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllSkill
{
    public int SkillId { get; set; }

    public string? SkillName { get; set; }

    public bool? SkillIsActive { get; set; }

    public string? SkillIdent { get; set; }

    public string? WorkersCompSkillTypeIdent { get; set; }

    public int SkillGroupId { get; set; }

    public string? SkillGroupName { get; set; }

    public string? SkillGroupShortName { get; set; }

    public string? WctypeIdent { get; set; }
}
