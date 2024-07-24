using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Contains skills needed for a job order, initially seeded with the skills associated with the PositionID, and allows the user to add additional needed skills.  
/// </summary>
public partial class BranchJobOrderSkill
{
    public int Id { get; set; }

    public int? JobOrderId { get; set; }

    public int? SkillId { get; set; }

    public int? SkillLevel { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public virtual VtSkill? Skill { get; set; }
}
