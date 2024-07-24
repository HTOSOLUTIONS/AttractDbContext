using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Superset of all contacts -- for analytical purposes. not exposed to application.  
/// </summary>
public partial class Contact
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Phone { get; set; }

    public string? EmailAddress { get; set; }

    public DateTime? CreatedDtUtc { get; set; }

    public DateTime? ModifiedDtUtc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public string? Website { get; set; }

    public int? TenantId { get; set; }

    public virtual ICollection<BranchClientContact> BranchClientContacts { get; set; } = new List<BranchClientContact>();

    public virtual ICollection<ClientJobsiteContact> ClientJobsiteContacts { get; set; } = new List<ClientJobsiteContact>();
}
