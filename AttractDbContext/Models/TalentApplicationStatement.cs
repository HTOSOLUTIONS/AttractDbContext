using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentApplicationStatement
{
    public int Id { get; set; }

    public int TalentId { get; set; }

    public int StatementId { get; set; }

    public string TalentAnswer { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public int? TenantId { get; set; }

    public int? EmployeeId { get; set; }

    public virtual BranchEmployee? Employee { get; set; }

    public virtual BranchApplicationStatement Statement { get; set; } = null!;

    public virtual Talent Talent { get; set; } = null!;

    public virtual Tenant? Tenant { get; set; }
}
