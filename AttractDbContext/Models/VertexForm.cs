using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class VertexForm
{
    public string? TaxIdentifierId { get; set; }

    public string? GeocodeId { get; set; }

    public string? SchoolDistrictId { get; set; }

    public string? TaxName { get; set; }

    public string? StartDate { get; set; }

    public string? StopDate { get; set; }

    public string? FormFieldIdentifier { get; set; }

    public string? ParentFormId { get; set; }

    public string? FormFieldDescriptiveName { get; set; }

    public string? FormDocumentation { get; set; }

    public string? ReciprocalJurisdictionGeoCodeId { get; set; }
}
