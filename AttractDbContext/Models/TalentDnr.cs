using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentDnr
{
    public int Id { get; set; }

    public int? TalentId { get; set; }

    public int? JobOrderId { get; set; }

    public int? JobSiteId { get; set; }

    public int? BranchClientId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public string? Dnrnote { get; set; }
}
