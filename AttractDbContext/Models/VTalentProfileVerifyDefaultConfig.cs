using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VTalentProfileVerifyDefaultConfig
{
    public int SectionDefId { get; set; }

    public string? SectionIdentifier { get; set; }

    public string? SectionDisplayName { get; set; }

    public int? TenantId { get; set; }

    public bool? SectionSupported { get; set; }

    public int? MaxRows { get; set; }

    public int? DefaultOrder { get; set; }
}
