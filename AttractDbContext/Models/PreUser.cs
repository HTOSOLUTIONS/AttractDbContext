using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class PreUser
{
    public int Id { get; set; }

    public string? AccountInviteId { get; set; }

    public string? InvitedUserId { get; set; }

    public int? AppRoleId { get; set; }

    public string? EmailAddress { get; set; }

    public string JsonData { get; set; } = null!;

    public DateTime? CreatedDtutc { get; set; }

    public string? Token { get; set; }

    public virtual AccountInvite? AccountInvite { get; set; }

    public virtual AppRole? AppRole { get; set; }

    public virtual User? InvitedUser { get; set; }
}
