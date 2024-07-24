﻿using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class TenantworkcompcodesStatesBak
{
    public int Id { get; set; }

    public int? TenantWorkcompCodeId { get; set; }

    public string? StateId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDtutc { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? ModifiedDtutc { get; set; }

    public string? ModifiedByUserId { get; set; }
}
