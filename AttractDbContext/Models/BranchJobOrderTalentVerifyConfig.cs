using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchJobOrderTalentVerifyConfig
{
    public int Id { get; set; }

    public int? JobOrderId { get; set; }

    public int? SectionDefId { get; set; }

    public bool? IsIncluded { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public virtual BranchJobOrder? JobOrder { get; set; }

    public virtual TalentProfileVerifySectionDef? SectionDef { get; set; }
}
