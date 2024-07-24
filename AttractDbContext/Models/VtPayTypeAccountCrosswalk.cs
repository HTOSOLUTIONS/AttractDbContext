using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup 
/// </summary>
public partial class VtPayTypeAccountCrosswalk
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public string? LookupValue { get; set; }

    public bool? IsActive { get; set; }

    public int? PaytypeId { get; set; }

    public int? AccountId { get; set; }
}
