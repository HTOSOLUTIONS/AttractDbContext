using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// Positions, as defined for a client, from which base wages and other information flows.  
/// </summary>
public partial class BranchClientPositionDefinition
{
    public int Id { get; set; }

    public int? BranchClientId { get; set; }

    public string? PositionName { get; set; }

    public int? WorkersCompCode { get; set; }

    public decimal? BaseWage { get; set; }

    public decimal? BaseBillable { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public decimal? OvertimeBillable { get; set; }

    public bool? IsActive { get; set; }

    public decimal? DoubleTimeBillable { get; set; }

    public virtual BranchClient? BranchClient { get; set; }

    public virtual ICollection<BranchClientPositionDefSkill> BranchClientPositionDefSkills { get; set; } = new List<BranchClientPositionDefSkill>();
}
