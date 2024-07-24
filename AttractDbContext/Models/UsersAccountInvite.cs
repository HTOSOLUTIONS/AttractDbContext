using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class UsersAccountInvite
{
    public int Id { get; set; }

    public string AccountInviteId { get; set; } = null!;

    public string? InvitedUserId { get; set; }

    public virtual AccountInvite AccountInvite { get; set; } = null!;
}
