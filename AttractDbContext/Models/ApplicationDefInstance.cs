using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class ApplicationDefInstance
{
    public int Id { get; set; }

    public int TemplateId { get; set; }

    public int TenantId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public bool? IsApprovedForUse { get; set; }

    public string? ApprovedForUseByUserId { get; set; }

    public DateTime? ApprovedForUseDtutc { get; set; }
}
