using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentJobOrderApplicationInterviewQuestion
{
    public int Id { get; set; }

    public int? ApplicationDefId { get; set; }

    public int? TalentId { get; set; }

    public int? JobOrderId { get; set; }

    public int? QuestionId { get; set; }

    public string? ResponseText { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }
}
