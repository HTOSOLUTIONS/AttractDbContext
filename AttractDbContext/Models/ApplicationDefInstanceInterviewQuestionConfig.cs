using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class ApplicationDefInstanceInterviewQuestionConfig
{
    public int Id { get; set; }

    public int? QuestionId { get; set; }

    public int? InstanceId { get; set; }

    public bool? IsIncluded { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }
}
