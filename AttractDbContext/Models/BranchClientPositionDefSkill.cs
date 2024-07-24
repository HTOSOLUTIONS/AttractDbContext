using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// For each Position, the skills needed for the position. This is used for matching talent to positions. 
/// </summary>
public partial class BranchClientPositionDefSkill
{
    public int Id { get; set; }

    public int? PositionId { get; set; }

    public int? SkillId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public virtual BranchClientPositionDefinition? Position { get; set; }
}
