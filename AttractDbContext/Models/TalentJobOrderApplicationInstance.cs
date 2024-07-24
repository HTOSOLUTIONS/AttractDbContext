using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentJobOrderApplicationInstance
{
    public int Id { get; set; }

    public int ApplicationDefInstanceId { get; set; }

    public bool? IsStale { get; set; }

    public bool? IsComplete { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public int? TalentId { get; set; }

    public int? JobOrderId { get; set; }

    public virtual ICollection<TalentApplicationJobOrderShift> TalentApplicationJobOrderShifts { get; set; } = new List<TalentApplicationJobOrderShift>();

    public virtual ICollection<TalentConditionalJobOffer> TalentConditionalJobOffers { get; set; } = new List<TalentConditionalJobOffer>();
}
