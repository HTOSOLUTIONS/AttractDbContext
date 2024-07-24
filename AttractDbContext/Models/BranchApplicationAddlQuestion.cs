using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchApplicationAddlQuestion
{
    public int Id { get; set; }

    public int BranchId { get; set; }

    public string QuestionText { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public virtual TenantBranch Branch { get; set; } = null!;

    public virtual ICollection<TalentApplicationAddlQuestion> TalentApplicationAddlQuestions { get; set; } = new List<TalentApplicationAddlQuestion>();
}
