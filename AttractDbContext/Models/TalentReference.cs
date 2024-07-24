using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentReference
{
    public int Id { get; set; }

    public int TalentId { get; set; }

    public string ReferenceName { get; set; } = null!;

    public string? Email { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public virtual Talent Talent { get; set; } = null!;
}
