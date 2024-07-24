using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class ApplicationTenantInterviewQuestion
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public string QuestionText { get; set; } = null!;

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }
}
