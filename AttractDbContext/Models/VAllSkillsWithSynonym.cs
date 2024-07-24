using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VAllSkillsWithSynonym
{
    public int? SkillId { get; set; }

    public string? SkillName { get; set; }

    public string? SynonymName { get; set; }
}
