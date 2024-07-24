using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentConditionalJobOffer
{
    public int Id { get; set; }

    public int TalentId { get; set; }

    public int BranchId { get; set; }

    public int AppId { get; set; }

    public DateTime? OfferDate { get; set; }

    public DateTime? HireDate { get; set; }

    public string? Conditions { get; set; }

    public string? Notes { get; set; }

    public int? TalentResponseId { get; set; }

    public DateTime? TalentResponseDate { get; set; }

    public bool IsActive { get; set; }

    public string CreatedByUserId { get; set; } = null!;

    public DateTime CreatedDtutc { get; set; }

    public string Modifiedbyuserid { get; set; } = null!;

    public DateTime ModifiedDtutc { get; set; }

    public virtual TalentJobOrderApplicationInstance App { get; set; } = null!;

    public virtual TenantBranch Branch { get; set; } = null!;

    public virtual Talent Talent { get; set; } = null!;

    public virtual VtAcceptedDeclinedOffer? TalentResponse { get; set; }
}
