using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class ApplicationDefInstanceContent
{
    public int Id { get; set; }

    public int? InstanceId { get; set; }

    public string? ContentKey { get; set; }

    public string? ContentValue { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }
}
