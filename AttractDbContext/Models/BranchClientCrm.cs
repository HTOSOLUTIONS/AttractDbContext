using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchClientCrm
{
    public int Id { get; set; }

    public int? BranchClientId { get; set; }

    public decimal? PotentialCloseValue { get; set; }

    public int? PotentialOpportunityTierId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public virtual BranchClient? BranchClient { get; set; }

    public virtual VtClientOppValue? PotentialOpportunityTier { get; set; }
}
