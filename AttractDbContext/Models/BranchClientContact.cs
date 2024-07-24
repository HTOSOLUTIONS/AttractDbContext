using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Contacts for each client.  
/// </summary>
public partial class BranchClientContact
{
    public int Id { get; set; }

    public int? ContactId { get; set; }

    public int? BranchClientId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtUtc { get; set; }

    public DateTime? ModifiedDtUtc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public string? Role { get; set; }

    public string? Department { get; set; }

    public int? IsInvoiceable { get; set; }

    public int? Type { get; set; }

    public virtual BranchClient? BranchClient { get; set; }

    public virtual Contact? Contact { get; set; }
}
