using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentEmploymentHistory
{
    public int Id { get; set; }

    public int TalentId { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string CompanyName { get; set; } = null!;

    public string Position { get; set; } = null!;

    public string? CompanyAddress { get; set; }

    public string? CompanyPhone { get; set; }

    public string? Title { get; set; }

    public string? Responsabilities { get; set; }

    public string? LeavingReason { get; set; }

    public decimal? EndingSallary { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public virtual Talent Talent { get; set; } = null!;
}
