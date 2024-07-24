using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VtWcfootnoteId
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public bool? IsActive { get; set; }

    public string? ExternalId { get; set; }
}
