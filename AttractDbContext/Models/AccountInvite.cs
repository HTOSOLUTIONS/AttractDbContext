using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class AccountInvite
{
    public string Id { get; set; } = null!;

    public string? InviteType { get; set; }

    public int? JobOrderId { get; set; }

    public string? InvitedByUserId { get; set; }

    public DateTime ExpirationDate { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public virtual BranchJobOrder? JobOrder { get; set; }

    public virtual ICollection<PreUser> PreUsers { get; set; } = new List<PreUser>();

    public virtual ICollection<UsersAccountInvite> UsersAccountInvites { get; set; } = new List<UsersAccountInvite>();
}
