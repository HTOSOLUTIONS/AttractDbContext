using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Unsatisfied invitations for users.  
/// </summary>
public partial class UserAccountInvite
{
    public int Id { get; set; }

    public string? Token { get; set; }

    public string? UserId { get; set; }

    public DateTime? ExpiresDt { get; set; }

    public virtual User? User { get; set; }
}
