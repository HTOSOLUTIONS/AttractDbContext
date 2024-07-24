using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

/// <summary>
/// variable table - lookup  
/// </summary>
public partial class VtDocumentType
{
    public int Id { get; set; }

    public string? VtValue { get; set; }

    public string? LookupValue { get; set; }

    public bool? IsActive { get; set; }

    public bool? OnlyAllowOneActive { get; set; }

    public virtual ICollection<VtDocumentTypeTemplate> VtDocumentTypeTemplates { get; set; } = new List<VtDocumentTypeTemplate>();
}
