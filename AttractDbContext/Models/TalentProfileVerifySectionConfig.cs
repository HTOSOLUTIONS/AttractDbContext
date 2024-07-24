using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentProfileVerifySectionConfig
{
    public int Id { get; set; }

    public int? SectionDefId { get; set; }

    public int? TenantId { get; set; }

    public bool? SectionSupported { get; set; }

    public int? MaxRows { get; set; }

    public int? DefaultOrder { get; set; }

    public virtual TalentProfileVerifySectionDef? SectionDef { get; set; }
}
