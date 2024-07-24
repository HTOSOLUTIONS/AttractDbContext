using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// DEPRECATED 
/// </summary>
public partial class BranchClientsWccode
{
    public int Id { get; set; }

    public int? BranchClientId { get; set; }

    public int? Wccode { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public virtual BranchClient? BranchClient { get; set; }
}
