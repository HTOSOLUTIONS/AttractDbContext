using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TalentDrugScreensResult
{
    public int Id { get; set; }

    public int? DrugScreenId { get; set; }

    public int? DocumentId { get; set; }

    public int? ResultId { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }
}
