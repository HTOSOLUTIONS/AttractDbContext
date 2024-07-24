using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentAtworkHistory
{
    public int Id { get; set; }

    public int TalentId { get; set; }

    public bool? WorkedAtWorkBefore { get; set; }

    public string? WorkedLocation { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public int? WorkedBranchId { get; set; }

    public virtual Talent Talent { get; set; } = null!;
}
