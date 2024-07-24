using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VWorkCompCodesParentTenant
{
    public int Id { get; set; }

    public int? TenantId { get; set; }

    public string? Wccode { get; set; }

    public string? Descrip { get; set; }

    public decimal? LossCost { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Premium { get; set; }

    public int? FootnoteId { get; set; }

    public int? HazardgroupId { get; set; }

    public int? IndustryGroupId { get; set; }

    public string? Phraseology { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateOnly? RateBeginDt { get; set; }

    public DateOnly? RateEndDt { get; set; }
}
