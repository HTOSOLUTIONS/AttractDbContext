using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentApplicationAddlQuestion
{
    public int Id { get; set; }

    public int TalentId { get; set; }

    public int QuestionId { get; set; }

    public string TalentAnswer { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public virtual BranchApplicationAddlQuestion Question { get; set; } = null!;

    public virtual Talent Talent { get; set; } = null!;
}
