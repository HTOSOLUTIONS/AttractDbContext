using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchJobOrderClientPaperwork
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Descrip { get; set; }

    public int? JobOrderId { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public bool IsActive { get; set; }

    public bool IsRequired { get; set; }
}
