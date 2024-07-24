using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Contacts who are specifically assigned to job sites.  
/// </summary>
public partial class ClientJobsiteContact
{
    public int Id { get; set; }

    public int? ContactId { get; set; }

    public int? ClientJobSiteId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtUtc { get; set; }

    public DateTime? ModifiedDtUtc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public int? BranchClientId { get; set; }

    public bool? SendInvoices { get; set; }

    public virtual ClientJobSite? ClientJobSite { get; set; }

    public virtual Contact? Contact { get; set; }
}
