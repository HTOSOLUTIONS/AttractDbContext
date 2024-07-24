using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchWorkersCompCode
{
    public int Id { get; set; }

    public int? TenantWorkcompCodeId { get; set; }

    public string? BranchId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public decimal? LossCost { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Premium { get; set; }
}
