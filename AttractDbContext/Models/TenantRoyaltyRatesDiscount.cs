using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TenantRoyaltyRatesDiscount
{
    public int Id { get; set; }

    public int? TenantBaseRateId { get; set; }

    public decimal? RateDiscount { get; set; }

    public DateTime? RateDiscountStartDt { get; set; }

    public DateTime? RateDiscountEndDt { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public virtual TenantsRoyaltyRate? TenantBaseRate { get; set; }
}
