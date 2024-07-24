using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchClientConfig
{
    public int Id { get; set; }

    public int? BranchClientId { get; set; }

    public string? ConfigOption { get; set; }

    public string? ConfigValue { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }
}
