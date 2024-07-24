﻿using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class BranchJobOrderStatementsConfig
{
    public int Id { get; set; }

    public int? StatementId { get; set; }

    public int? JobOrderId { get; set; }

    public bool? IsIncluded { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }
}
