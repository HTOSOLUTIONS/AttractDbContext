using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TenantApplicationTemplate
{
    public int Id { get; set; }

    public string? TemplateName { get; set; }

    public int TenantId { get; set; }

    public bool? IsActive { get; set; }

    public int? DerivedFromId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }
}
