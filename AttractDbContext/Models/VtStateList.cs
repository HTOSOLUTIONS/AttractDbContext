using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup  
/// </summary>
public partial class VtStateList
{
    public string? Abbrev { get; set; }

    public string? VtValue { get; set; }

    public bool? Isactive { get; set; }

    public string Id { get; set; } = null!;

    public virtual ICollection<PayCheckFinalPayDetail> PayCheckFinalPayDetails { get; set; } = new List<PayCheckFinalPayDetail>();

    public virtual ICollection<Talent> Talents { get; set; } = new List<Talent>();
}
