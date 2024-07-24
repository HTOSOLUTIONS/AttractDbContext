using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchApplicationStatement
{
    public int Id { get; set; }

    public int BranchId { get; set; }

    public string StatementText { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public virtual TenantBranch Branch { get; set; } = null!;

    public virtual ICollection<TalentApplicationStatement> TalentApplicationStatements { get; set; } = new List<TalentApplicationStatement>();
}
