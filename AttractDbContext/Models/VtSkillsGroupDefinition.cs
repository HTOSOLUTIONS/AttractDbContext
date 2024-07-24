using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup  
/// </summary>
public partial class VtSkillsGroupDefinition
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public string? LookupValue { get; set; }

    public bool? IsActive { get; set; }

    public string? ShortName { get; set; }

    public string? WctypeIdent { get; set; }

    public virtual ICollection<SkillGroup> SkillGroups { get; set; } = new List<SkillGroup>();
}
