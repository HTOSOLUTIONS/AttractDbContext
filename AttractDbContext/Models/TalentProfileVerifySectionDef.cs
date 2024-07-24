using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentProfileVerifySectionDef
{
    public int Id { get; set; }

    public string? SectionIdentifier { get; set; }

    public string? SectionDisplayName { get; set; }

    public virtual ICollection<BranchJobOrderTalentVerifyConfig> BranchJobOrderTalentVerifyConfigs { get; set; } = new List<BranchJobOrderTalentVerifyConfig>();

    public virtual ICollection<TalentProfileVerifySectionConfig> TalentProfileVerifySectionConfigs { get; set; } = new List<TalentProfileVerifySectionConfig>();
}
