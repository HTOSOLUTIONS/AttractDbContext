using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class PayChecksTimeDetailsAssoc
{
    public int Id { get; set; }

    public int? TimeWorkedDetailsId { get; set; }

    public int? PayCheckId { get; set; }

    public int? PayCheckPaysId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? ModifiedByUserId { get; set; }
}
