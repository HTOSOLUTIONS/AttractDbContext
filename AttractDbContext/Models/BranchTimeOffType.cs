using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchTimeOffType
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public string? TimeOffTypeName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }
}
