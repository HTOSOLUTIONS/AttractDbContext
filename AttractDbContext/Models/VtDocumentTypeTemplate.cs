using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VtDocumentTypeTemplate
{
    public int Id { get; set; }

    public string? DocUrl { get; set; }

    public DateOnly? EffectiveUseBeginDt { get; set; }

    public DateOnly? EffectiveUseEndDt { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? TemplateKey { get; set; }

    public virtual VtDocumentType? DocumentType { get; set; }
}
