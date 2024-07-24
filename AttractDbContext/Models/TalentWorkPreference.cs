using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentWorkPreference
{
    public int Id { get; set; }

    public int TalentId { get; set; }

    public int EmploymentTypeId { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public virtual VtEmploymentType EmploymentType { get; set; } = null!;

    public virtual Talent Talent { get; set; } = null!;
}
