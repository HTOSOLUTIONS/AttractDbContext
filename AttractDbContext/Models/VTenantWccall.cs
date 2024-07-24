using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VTenantWccall
{
    public int TenantWorkCompCodeId { get; set; }

    public string? Wccode { get; set; }

    public string? Descrip { get; set; }

    public string? Phraseology { get; set; }

    public bool? IsActive { get; set; }

    public int? TenantId { get; set; }

    public string? WccodeRev { get; set; }

    public string? DescripRev { get; set; }

    public string? PhraseRev { get; set; }
}
