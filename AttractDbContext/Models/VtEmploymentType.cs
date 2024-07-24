using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup  
/// </summary>
public partial class VtEmploymentType
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<TalentWorkPreference> TalentWorkPreferences { get; set; } = new List<TalentWorkPreference>();
}
