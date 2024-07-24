using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TenantsRoyaltyRate
{
    public int Id { get; set; }

    public int? TenantId { get; set; }

    public DateTime? EffectiveStartDt { get; set; }

    public DateTime? EffectiveEndDt { get; set; }

    public decimal? Rate { get; set; }

    public decimal? ParentRateLocked { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public int? ParentRateDynamic { get; set; }

    public virtual Tenant? Tenant { get; set; }

    public virtual ICollection<TenantRoyaltyRatesDiscount> TenantRoyaltyRatesDiscounts { get; set; } = new List<TenantRoyaltyRatesDiscount>();
}
