using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Associates a talent entity with a user account.  
/// </summary>
public partial class TalentUser
{
    public int Id { get; set; }

    public int? TalentId { get; set; }

    public string? UserId { get; set; }

    public virtual Talent? Talent { get; set; }
}
