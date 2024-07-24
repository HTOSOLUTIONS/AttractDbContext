using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// DEPRECATED 
/// </summary>
public partial class BranchClientSkill
{
    public int Id { get; set; }

    public int? BranchClientId { get; set; }

    public int? SkillId { get; set; }

    public bool? IsActive { get; set; }
}
