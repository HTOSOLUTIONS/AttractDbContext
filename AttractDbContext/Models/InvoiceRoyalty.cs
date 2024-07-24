using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class InvoiceRoyalty
{
    public int Id { get; set; }

    public int? InvoiceId { get; set; }

    public decimal? GrossAr { get; set; }

    public decimal? BaseRatePct { get; set; }

    public decimal? GrossRoyaltyValue { get; set; }

    public decimal? DiscountPct { get; set; }

    public decimal? EffectiveRate { get; set; }

    public decimal? NetRoyaltyValue { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public bool? IsJournaled { get; set; }

    public virtual Invoice? Invoice { get; set; }
}
