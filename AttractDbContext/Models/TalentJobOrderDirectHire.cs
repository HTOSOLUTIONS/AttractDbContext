using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentJobOrderDirectHire
{
    public int Id { get; set; }

    public int? TalentId { get; set; }

    public int? JobOrderId { get; set; }

    public decimal? FeeAmount { get; set; }

    public DateOnly? PlacementDate { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsRescinded { get; set; }

    public DateOnly? RescindedDt { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }
}
