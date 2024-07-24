using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VtClientDeactivationType
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public bool? IsActive { get; set; }

    public string? DisplayName { get; set; }
}
